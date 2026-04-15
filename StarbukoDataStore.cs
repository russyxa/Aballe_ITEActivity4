using System;
using System.Configuration;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Aballe_ITEActivity4.Domain;
using Aballe_ITEActivity4.DTOs;

namespace Aballe_ITEActivity4
{
    public static class StarbukoDataStore
    {
        private static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["StarbukoDb"].ConnectionString;

        // ── Helper: Hash password the same way MySQL SHA2() does ──────────────
        private static string HashPassword(string password)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        // ════════════════════════════════════════════════════════════════════
        // AUTH
        // ════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Returns the logged-in User object, or null if credentials are wrong.
        /// </summary>
        public static User Login(LoginDto dto)
        {
            string hash = HashPassword(dto.Password);

            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT u.user_id, u.role_id, u.username, u.full_name,
                           u.is_active, u.created_at, r.role_name
                    FROM users u
                    JOIN roles r ON u.role_id = r.role_id
                    WHERE u.username = @username
                      AND u.password_hash = @hash
                      AND u.is_active = 1";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", dto.Username);
                    cmd.Parameters.AddWithValue("@hash", hash);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserId = reader.GetInt32("user_id"),
                                RoleId = reader.GetInt32("role_id"),
                                Username = reader.GetString("username"),
                                FullName = reader.GetString("full_name"),
                                IsActive = reader.GetBoolean("is_active"),
                                CreatedAt = reader.GetDateTime("created_at"),
                                RoleName = reader.GetString("role_name")
                            };
                        }
                    }
                }
            }
            return null; // login failed
        }

        // ════════════════════════════════════════════════════════════════════
        // PRODUCTS
        // ════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Returns all available products for the menu panel.
        /// </summary>
        public static List<ProductDto> GetAllProducts()
        {
            var list = new List<ProductDto>();

            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT product_id, name, price, image_path
                    FROM products
                    WHERE is_available = 1
                    ORDER BY name";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ProductDto
                        {
                            ProductId = reader.GetInt32("product_id"),
                            Name = reader.GetString("name"),
                            FormattedPrice = $"₱{reader.GetDecimal("price"):F2}",
                            ImagePath = reader.IsDBNull(reader.GetOrdinal("image_path"))
                                                ? "" : reader.GetString("image_path")
                        });
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Inserts a new product. Returns true if successful.
        /// </summary>
        public static bool AddProduct(NewProductDto dto)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO products (name, price, image_path)
                    VALUES (@name, @price, @imagePath)";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", dto.Name);
                    cmd.Parameters.AddWithValue("@price", dto.Price);
                    cmd.Parameters.AddWithValue("@imagePath", dto.ImagePath);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ════════════════════════════════════════════════════════════════════
        // USERS
        // ════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Returns all users for the ManageUsersForm grid.
        /// </summary>
        public static List<UserDto> GetAllUsers()
        {
            var list = new List<UserDto>();

            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"
                    SELECT u.user_id, u.full_name, u.username,
                           u.is_active, r.role_name
                    FROM users u
                    JOIN roles r ON u.role_id = r.role_id
                    ORDER BY u.full_name";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new UserDto
                        {
                            UserId = reader.GetInt32("user_id"),
                            FullName = reader.GetString("full_name"),
                            Username = reader.GetString("username"),
                            RoleName = reader.GetString("role_name"),
                            IsActive = reader.GetBoolean("is_active")
                        });
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Returns all roles for the role dropdown in AddUserForm.
        /// </summary>
        public static List<Role> GetAllRoles()
        {
            var list = new List<Role>();

            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT role_id, role_name FROM roles";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Role(
                            reader.GetInt32("role_id"),
                            reader.GetString("role_name")
                        ));
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Inserts a new user. Returns true if successful.
        /// </summary>
        public static bool AddUser(NewUserDto dto)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO users (role_id, username, password_hash, full_name)
                    VALUES (@roleId, @username, @hash, @fullName)";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@roleId", dto.RoleId);
                    cmd.Parameters.AddWithValue("@username", dto.Username);
                    cmd.Parameters.AddWithValue("@hash", HashPassword(dto.Password));
                    cmd.Parameters.AddWithValue("@fullName", dto.FullName);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Toggles a user's active status. Returns true if successful.
        /// </summary>
        public static bool SetUserActive(int userId, bool isActive)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = "UPDATE users SET is_active = @active WHERE user_id = @userId";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@active", isActive ? 1 : 0);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool SetProductAvailable(int productId, bool isAvailable)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = "UPDATE products SET is_available = @val WHERE product_id = @id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@val", isAvailable ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", productId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ════════════════════════════════════════════════════════════════════
        // TRANSACTIONS
        // ════════════════════════════════════════════════════════════════════

        /// <summary>
        /// Saves a completed transaction and all its items. Returns true if successful.
        /// </summary>
        // Change 'bool' to 'int' here
        public static int SaveTransaction(CheckoutDto checkout)
        {
            // Make sure 'ConnectionString' below matches your actual connection string variable in this file!
            using (var connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert the main transaction record (Updated to match your DB exactly!)
                        string insertTxQuery = @"INSERT INTO transactions (transaction_date, total_amount, user_id, tendered, change_amount) 
                         VALUES (@date, @total, @userId, @tendered, @changeAmount);
                         SELECT LAST_INSERT_ID();";

                        int newTransactionId = 0;
                        using (var cmd = new MySqlCommand(insertTxQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@date", DateTime.Now);
                            cmd.Parameters.AddWithValue("@total", checkout.TotalAmount);
                            cmd.Parameters.AddWithValue("@userId", checkout.CashierId); // Maps to user_id
                            cmd.Parameters.AddWithValue("@tendered", checkout.Tendered);
                            cmd.Parameters.AddWithValue("@changeAmount", checkout.ChangeAmount);

                            newTransactionId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. Insert the cart items (Updated to match your unit_price column!)
                        string insertItemQuery = @"INSERT INTO transaction_items (transaction_id, product_id, quantity, unit_price) 
                           VALUES (@txId, @prodId, @qty, @unitPrice)";

                        foreach (var item in checkout.Items)
                        {
                            using (var cmd = new MySqlCommand(insertItemQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@txId", newTransactionId);
                                cmd.Parameters.AddWithValue("@prodId", item.ProductId);
                                cmd.Parameters.AddWithValue("@qty", item.Quantity);
                                cmd.Parameters.AddWithValue("@unitPrice", item.UnitPrice);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        // 3. Commit the save and return the new ID
                        transaction.Commit();
                        return newTransactionId;
                    }
                    catch (Exception ex)
                    {
                        // Temporarily show the exact MySQL error so we can fix it!
                        System.Windows.Forms.MessageBox.Show("DB Error: " + ex.Message);
                        transaction.Rollback();
                        return 0;
                    }
                }
            }
        }

        public static bool UpdateUser(int userId, string fullName,string username, string? newPassword, int roleId)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();

                string sql = newPassword != null
                    ? @"UPDATE users
                SET full_name = @fullName,
                    username = @username,
                    password_hash = @hash,
                    role_id = @roleId
                WHERE user_id = @userId"
                    : @"UPDATE users
                SET full_name = @fullName,
                    username = @username,
                    role_id = @roleId
                WHERE user_id = @userId";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@roleId", roleId);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    if (newPassword != null)
                        cmd.Parameters.AddWithValue("@hash", HashPassword(newPassword));

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool UpdateProduct(int productId, string name,
                                 decimal price, string imagePath)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"UPDATE products
                       SET name       = @name,
                           price      = @price,
                           image_path = @imagePath
                       WHERE product_id = @id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@imagePath", imagePath);
                    cmd.Parameters.AddWithValue("@id", productId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteUser(int userId)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM users WHERE user_id = @userId";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteProduct(int productId)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM products WHERE product_id = @id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static List<Transaction> GetAllTransactions()
        {
            var list = new List<Transaction>();
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                // Sorting by date descending so latest transactions show first
                string sql = "SELECT * FROM transactions ORDER BY transaction_date DESC";
                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transaction
                        {
                            TransactionId = Convert.ToInt32(reader["transaction_id"]),
                            UserId = Convert.ToInt32(reader["user_id"]),
                            TotalAmount = Convert.ToDecimal(reader["total_amount"]),
                            Tendered = Convert.ToDecimal(reader["tendered"]),
                            ChangeAmount = Convert.ToDecimal(reader["change_amount"]),
                            TransactionDate = Convert.ToDateTime(reader["transaction_date"])
                        });
                    }
                }
            }
            return list;
        }
    }
}
