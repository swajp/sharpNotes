using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sharpNotes
{
    public static class SqlRepository
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sharpNotes;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static void SignupUser(string username, string password)
        {
            byte[] salt, hash;

            HMACSHA512 hmac = new HMACSHA512();

            hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            salt = hmac.Key;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Users (Username, PasswordHash, PasswordSalt) VALUES (@username, @hash, @salt)";
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("hash", hash);
                    cmd.Parameters.AddWithValue("salt", salt);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        public static User? GetUser(string username)
        {
            User? user = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [Users] WHERE Username=@Username";
                    cmd.Parameters.AddWithValue("Username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User((int)reader["Id"], reader["Username"].ToString(), (byte[])reader["PasswordHash"], (byte[])reader["PasswordSalt"]);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return user;
        }
        public static List<Note> GetNotes(int ownerId)
        {
            List<Note> notes = new List<Note>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM [Notes] WHERE OwnerId=@OwnerId";
                    cmd.Parameters.AddWithValue("OwnerId", ownerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var note = new Note((int)reader["NoteId"]
                                             , reader["Title"].ToString()
                                             , reader["Text"].ToString()
                                             , (int)reader["OwnerId"]);
                            notes.Add(note);
                        }
                    }
                }
                sqlConnection.Close();
            }
            return notes;
        }
        public static void DeleteNote(int noteId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [Notes] WHERE NoteId=@NoteId";
                    cmd.Parameters.AddWithValue("NoteId", noteId);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public static void EditNote(int noteId, string title, string text)
        { 
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE [Notes] SET Title=@Title, Text=@Text WHERE NoteId=@NoteId";
                    cmd.Parameters.AddWithValue("NoteId", noteId);
                    cmd.Parameters.AddWithValue("Title", title);
                    cmd.Parameters.AddWithValue("Text", text);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
        public static void AddNote(string title, string text, int ownerId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (SqlCommand cmd = sqlConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [Notes] (Title, Text, OwnerId) VALUES (@Title, @Text, @OwnerId) ";
                    cmd.Parameters.AddWithValue("Title", title);
                    cmd.Parameters.AddWithValue("Text", text);
                    cmd.Parameters.AddWithValue("OwnerId", ownerId);
                    cmd.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
        }
    }
}
