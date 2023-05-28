using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp
{
    public static class Utils
    {
        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            //Convert the input string to a byte array and compute the hash.
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            //Create a new Stringbuilder to collect the bytes and create  string
            StringBuilder stringBuilder = new StringBuilder();

            //Loop through each byte of the hashed data and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        public static string DefaultHashedPassword()
        {
            SHA256 sha = SHA256.Create();

            //Convert the input string to a byte array and compute the hash.
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes("PassWord123"));

            //Create a new Stringbuilder to collect the bytes and create  string
            StringBuilder stringBuilder = new StringBuilder();

            //Loop through each byte of the hashed data and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}
