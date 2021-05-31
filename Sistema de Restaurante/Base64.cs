using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Base64
    {
        static public string Base64Encode(string plainText)
        {
            try
            {
                byte[] textoAsBytes = Encoding.ASCII.GetBytes(plainText);
                string resultado = System.Convert.ToBase64String(textoAsBytes);
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        static public string Base64Decode(string base64EncodedData)
        {
            try
            {
                byte[] dadosAsBytes = System.Convert.FromBase64String(base64EncodedData);
                string resultado = System.Text.ASCIIEncoding.ASCII.GetString(dadosAsBytes);
                return resultado;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
