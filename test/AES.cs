﻿using Microsoft.SqlServer.Server;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace test
{
    public class AES
    {
        private static readonly SecureRandom Random = new SecureRandom();

        // Pre-configured Encryption Parameters
        public static readonly int NonceBitSize = 128;
        public static readonly int MacBitSize = 128;
        public static readonly int KeyBitSize = 256;

        private AES() { }

        public static byte[] NewKey()
        {
            var key = new byte[KeyBitSize / 8];
            Random.NextBytes(key);
            return key;
        }

        public static byte[] NewIv()
        {
            var iv = new byte[NonceBitSize / 8];
            Random.NextBytes(iv);
            return iv;
        }

        public static Byte[] HexToByte(string hexStr)
        {
            byte[] bArray = new byte[hexStr.Length / 2];
            for (int i = 0; i < (hexStr.Length / 2); i++)
            {
                byte firstNibble = Byte.Parse(hexStr.Substring((2 * i), 1), System.Globalization.NumberStyles.HexNumber); // [x,y)
                byte secondNibble = Byte.Parse(hexStr.Substring((2 * i) + 1, 1), System.Globalization.NumberStyles.HexNumber);
                int finalByte = (secondNibble) | (firstNibble << 4); // bit-operations only with numbers, not bytes.
                bArray[i] = (byte)finalByte;
            }
            return bArray;
        }


        public static string toHex(byte[] data)
        {
            string hex = string.Empty;
            foreach (byte c in data)
            {
                hex += c.ToString("X2");
            }
            return hex;
        }


        public static string toHex(string asciiString)
        {
            string hex = string.Empty;
            foreach (char c in asciiString)
            {
                int tmp = c;
                hex += string.Format("{0:x2}", System.Convert.ToUInt32(tmp.ToString()));
            }
            return hex;
        }

        public static string encrypt(string PlainText, byte[] key, byte[] iv)
        {
            string sR = string.Empty;
            try
            {
                byte[] plainBytes = Encoding.UTF8.GetBytes(PlainText);

                GcmBlockCipher cipher = new GcmBlockCipher(new AesFastEngine());
                AeadParameters parameters = new AeadParameters(new KeyParameter(key), 128, iv, null);

                cipher.Init(true, parameters);

                byte[] encryptedBytes = new byte[cipher.GetOutputSize(plainBytes.Length)];
                Int32 retLen = cipher.ProcessBytes(plainBytes, 0, plainBytes.Length, encryptedBytes, 0);
                cipher.DoFinal(encryptedBytes, retLen);
                sR = Convert.ToBase64String(encryptedBytes, Base64FormattingOptions.None);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return sR;
        }
        public static byte[] encrypt_Byte(byte[] byteData, byte[] key, byte[] iv)
        {
            byte[] sR = null;
            try
            {
                byte[] plainBytes = byteData;

                GcmBlockCipher cipher = new GcmBlockCipher(new AesFastEngine());
                AeadParameters parameters = new AeadParameters(new KeyParameter(key), 128, iv, null);

                cipher.Init(true, parameters);

                byte[] encryptedBytes = new byte[cipher.GetOutputSize(plainBytes.Length)];
                Int32 retLen = cipher.ProcessBytes(plainBytes, 0, plainBytes.Length, encryptedBytes, 0);
                cipher.DoFinal(encryptedBytes, retLen);
                sR = encryptedBytes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return sR;
        }

        public static string decrypt(string EncryptedText, byte[] key, byte[] iv)
        {
            string sR = string.Empty;
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(EncryptedText);

                GcmBlockCipher cipher = new GcmBlockCipher(new AesFastEngine());
                AeadParameters parameters = new AeadParameters(new KeyParameter(key), 128, iv, null);
                //ParametersWithIV parameters = new ParametersWithIV(new KeyParameter(key), iv);

                cipher.Init(false, parameters);
                byte[] plainBytes = new byte[cipher.GetOutputSize(encryptedBytes.Length)];
                Int32 retLen = cipher.ProcessBytes(encryptedBytes, 0, encryptedBytes.Length, plainBytes, 0);
                cipher.DoFinal(plainBytes, retLen);

                sR = Encoding.UTF8.GetString(plainBytes).TrimEnd("\r\n\0".ToCharArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return sR;
        }

        public static byte[] decrypt_Byte(byte[] byteData, byte[] key, byte[] iv)
        {
            byte[] sR = null;
            try
            {
                byte[] encryptedBytes = byteData;

                GcmBlockCipher cipher = new GcmBlockCipher(new AesFastEngine());
                AeadParameters parameters = new AeadParameters(new KeyParameter(key), 128, iv, null);
                //ParametersWithIV parameters = new ParametersWithIV(new KeyParameter(key), iv);

                cipher.Init(false, parameters);
                byte[] plainBytes = new byte[cipher.GetOutputSize(encryptedBytes.Length)];
                Int32 retLen = cipher.ProcessBytes(encryptedBytes, 0, encryptedBytes.Length, plainBytes, 0);
                cipher.DoFinal(plainBytes, retLen);

                sR = plainBytes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            return sR;
        }

        public static byte[] ConvertStringToByte(string hexString)
        {
            byte[] byteArray = new byte[hexString.Length / 2];
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }
            return byteArray;
        }




        public static string Aes_cbc_128_Encrypt1(string plainText, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor();

                byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(plainBytes, 0, plainBytes.Length);
                    }

                    byte[] encryptedBytes = ms.ToArray();
                    string encryptedText = Convert.ToBase64String(encryptedBytes);
                    return encryptedText;
                }
            }
        }

        public static string Aes_cbc_128_Decrypt(string encryptedText, byte[] key, byte[] iv)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Key = key;
                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor();

                using (MemoryStream ms = new MemoryStream(encryptedBytes))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            string decryptedText = sr.ReadToEnd();
                            return decryptedText;
                        }
                    }
                }
            }
        }
    }
}
