using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace junio28.servicio
{
    public class Util
    {
        public static string Encriptar(string txt)
        {
            string salt = "SALT SECRETO123";
            byte[] data = System.Text.Encoding.ASCII.GetBytes(salt + txt);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}