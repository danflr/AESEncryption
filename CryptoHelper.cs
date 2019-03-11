using System.Security.Cryptography;
using System.IO;
using System;
using System.Drawing;
using System.Text;

namespace AESEncryption
{
    class CryptoHelper
    {
        public static string Cifrar(string texto, string llave)
        {
            byte[] aCifrar = System.Text.Encoding.UTF8.GetBytes(texto);
            byte[] keyArray = System.Text.Encoding.UTF8.GetBytes(llave);
            keyArray = SHA256.Create().ComputeHash(keyArray);
            byte[] resultado = null;

            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(keyArray, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(aCifrar, 0, aCifrar.Length);
                        cs.Close();
                    }
                    resultado = ms.ToArray();
                }
            }
            return System.Convert.ToBase64String(resultado);
        }

        public static string Descifrar(string texto, string llave)
        {
            byte[] aCifrar = System.Convert.FromBase64String(texto);
            byte[] keyArray = System.Text.Encoding.UTF8.GetBytes(llave);
            keyArray = SHA256.Create().ComputeHash(keyArray);
            byte[] resultado = null;

            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (RijndaelManaged AES = new RijndaelManaged())
                    {
                        AES.KeySize = 256;
                        AES.BlockSize = 128;

                        var key = new Rfc2898DeriveBytes(keyArray, saltBytes, 1000);
                        AES.Key = key.GetBytes(AES.KeySize / 8);
                        AES.IV = key.GetBytes(AES.BlockSize / 8);

                        AES.Mode = CipherMode.CBC;

                        using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(aCifrar, 0, aCifrar.Length);
                            cs.Close();
                        }
                        resultado = ms.ToArray();
                    }
                }
                return System.Text.Encoding.UTF8.GetString(resultado);
            } catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ocurrió un error al convertir la cadena de nuevo a su original, revise que la llave de cifrado sea correcta\n\nDetalles:\n" + ex.Message, "Error de conversión", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public static string CifrarImagen(string rutaImagen, string llave)
        {
            byte[] imgBytes = null;
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(rutaImagen))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    imgBytes = m.ToArray();
                    // Convert byte[] to Base64 String
                    //string base64String = System.Convert.ToBase64String(imgBytes);
                    //return base64String;
                }
            }
            byte[] keyArray = System.Text.Encoding.UTF8.GetBytes(llave);
            keyArray = SHA256.Create().ComputeHash(keyArray);
            byte[] resultado = null;

            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (RijndaelManaged AES = new RijndaelManaged())
                    {
                        AES.KeySize = 256;
                        AES.BlockSize = 128;

                        var key = new Rfc2898DeriveBytes(keyArray, saltBytes, 1000);
                        AES.Key = key.GetBytes(AES.KeySize / 8);
                        AES.IV = key.GetBytes(AES.BlockSize / 8);

                        AES.Mode = CipherMode.CBC;

                        using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(imgBytes, 0, imgBytes.Length);
                            cs.Close();
                        }
                        resultado = ms.ToArray();
                    }
                }

                //var bytes = System.Convert.FromBase64String(System.Convert.ToBase64String(resultado));
                using (var imageFile = new FileStream(rutaImagen.Replace(".", "-crypted.") , FileMode.Create))
                {
                    //imageFile.Write(bytes, 0, bytes.Length);
                    imageFile.Write(resultado, 0, resultado.Length);
                    imageFile.Flush();
                    imageFile.Close();
                }
                //return System.Drawing.Image.FromFile(rutaImagen.Replace(".", "-crypted."));
                return rutaImagen.Replace(".", "-crypted.");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ocurrió un error al cifrar la imagen. Detalles:\n\n" + ex.Message, "Error de conversión", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return rutaImagen;
            }
        }

    }
}
