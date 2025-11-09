using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace formLogin
{
    internal class Seguridad
    {
        /// Genera un hash SHA256 de la contraseña ingresada.
      
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2")); // convierte cada byte a hexadecimal
                }
                return sb.ToString();
            }
        }

        /// Verifica si la contraseña ingresada coincide con el hash almacenado.
        public static bool VerificarPassword(string passwordIngresada, string hashAlmacenado)
        {
            string hashIngresada = HashPassword(passwordIngresada);
            return hashIngresada.Equals(hashAlmacenado);
        }

    }
}
