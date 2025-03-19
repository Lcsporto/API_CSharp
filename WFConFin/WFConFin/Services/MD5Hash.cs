using System;
using System.Security.Cryptography;
using System.Text;

namespace WFConFin.Services
{
    public class MD5Hash
    {
        public static string CalcHash(string valor)
        {
            try
            {
                MD5 md5 = MD5.Create();
                byte[] inputBytes = Encoding.ASCII.GetBytes(valor);
                byte[] hash = md5.ComputeHash(inputBytes);
                StringBuilder Sb = new StringBuilder();

                for(int i = 0; i < hash.Length; i++)
                {
                    Sb.Append(hash[i].ToString("X2"));
                }
                return Sb.ToString();
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
