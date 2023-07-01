using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace sharpNotes
{
    public class User
    {
        public int Id { get; }
        public string Username { get; }
        public byte[] PasswordHash { get; internal set; }
        public byte[] PasswordSalt { get; internal set; }
        public User(int id, string username, string password)
        {
            Id = id;
            Username = username;
            SqlRepository.SignupUser(username, password);
        }
        public User(int id, string username, byte[] passwordHash, byte[] passwordSalt)
        {
            Id = id;
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
        }
        public bool VerifyPassword(string password)
        {
            byte[] hash;
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            return hash.SequenceEqual(PasswordHash);
        }
    }
}
