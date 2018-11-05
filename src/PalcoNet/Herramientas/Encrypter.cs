using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PalcoNet.Herramientas
{
    public static class Encrypter
    {

        public static string Encrypt256(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            var hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);

            StringBuilder output = new StringBuilder();
            foreach (byte xByte in hash)
            {
                output.Append(String.Format("{0:x2}", xByte));
            }

            return output.ToString();
        }

 
    }


}
