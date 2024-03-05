using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Add library
using System.Security.Cryptography;
namespace GestionPapeleria.Auxiliar
{
    internal class AesCrypt
    {

        //Creamos la clase
        //Entegrar un initialization vector distinto hace que un mismo password termine teniendo otra encriptación

        public static string IV = "frKz3XtkGnuX166m";
        public static string key = "frKz3XtkGnuX166mfrKz3XtkGnuX166m";

        //LLamada al serivicio de criptografía

        public static string Encrypt(string decripted)
        {

            byte[] textBytes = Encoding.ASCII.GetBytes(decripted);

            //Configuración del servicio que nos permitierá ejecutar el encriptador
            AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
            encdec.BlockSize = 128;
            encdec.KeySize = 256;
            encdec.Key = Encoding.ASCII.GetBytes(key);
            encdec.IV = Encoding.ASCII.GetBytes(IV);
            encdec.Padding = PaddingMode.PKCS7;
            encdec.Mode = CipherMode.CBC;

            //Encriptor 

            ICryptoTransform icrypt = encdec.CreateEncryptor(encdec.Key, encdec.IV);

            byte[] enc = icrypt.TransformFinalBlock(textBytes, 0, textBytes.Length);
            icrypt.Dispose();

            return Convert.ToBase64String(enc);
        }

        //Mismo metodo de forma inversa
        public static string Decrypt(string encrypted)
        {

            byte[] encbytes = Convert.FromBase64String(encrypted);

            //Configuración del servicio que nos permitierá ejecutar el encriptador
            AesCryptoServiceProvider encdec = new AesCryptoServiceProvider();
            encdec.BlockSize = 128;
            encdec.KeySize = 256;
            encdec.Key = Encoding.ASCII.GetBytes(key);
            encdec.IV = Encoding.ASCII.GetBytes(IV);
            encdec.Padding = PaddingMode.PKCS7;
            encdec.Mode = CipherMode.CBC;

            //Encriptor 

            ICryptoTransform icrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV);

            byte[] dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
            icrypt.Dispose();

            return Encoding.ASCII.GetString(dec);
        }
    }
}
