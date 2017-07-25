using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace NSGVisitorManagement.Classes
{
    public class Encryptor
    {
        // Internal value of the phrase used to generate the secret key
        private string _Phrase = "";
        //contains input file path and name
        private string _inputFile = "";
        //contains output file path and name
        private string _outputFile = "";
        enum TransformType { ENCRYPT = 0, DECRYPT = 1 }

        /// <value>Set the phrase used to generate the secret key.</value>
        public string Phrase
        {
            set
            {
                this._Phrase = value;
                this.GenerateKey(this._Phrase);
            }
        }

        // Internal initialization vector value to 
        // encrypt/decrypt the first block
        private byte[] _IV;

        // Internal secret key value
        private byte[] _Key;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="SecretPhrase">Secret phrase to generate key</param>
        public Encryptor(string SecretPhrase)
        {
            this.Phrase = "NIITYUVAJYOTI-SKILLREGISTRY@2012";
        }

        /// <summary>
        /// Encrypt the given value with the Rijndael algorithm.
        /// </summary>
        /// <param name="EncryptValue">Value to encrypt</param>
        /// <returns>Encrypted value. </returns>
        public string Encrypt(string EncryptValue)
        {
            try
            {
                if (EncryptValue.Length > 0)
                {
                    // Write the encrypted value into memory
                    byte[] input = Encoding.UTF8.GetBytes(EncryptValue);

                    // Retrieve the encrypted value and return it
                    return (Convert.ToBase64String(Transform(input, TransformType.ENCRYPT)));
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Decrypt the given value with the Rijndael algorithm.
        /// </summary>
        /// <param name="DecryptValue">Value to decrypt</param>
        /// <returns>Decrypted value. </returns>
        public string Decrypt(string DecryptValue)
        {
            try
            {
                if (DecryptValue.Length > 0)
                {
                    // Write the encrypted value into memory                    
                    byte[] input = Convert.FromBase64String(DecryptValue);

                    // Retrieve the decrypted value and return it
                    return (Encoding.UTF8.GetString(Transform(input, TransformType.DECRYPT)));
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Encrypt the given value with the Rijndael algorithm.
        /// </summary>
        /// <param name="EncryptValue">Value to encrypt</param>
        /// <returns>Encrypted value. </returns>
        public void Encrypt(string InputFile, string OutputFile)
        {
            try
            {
                if ((InputFile != null) && (InputFile.Length > 0))
                {
                    _inputFile = InputFile;
                }
                if ((OutputFile != null) && (OutputFile.Length > 0))
                {
                    _outputFile = OutputFile;
                }
                Transform(null, TransformType.ENCRYPT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Decrypt the given value with the Rijndael algorithm.
        /// </summary>
        /// <param name="DecryptValue">Value to decrypt</param>
        /// <returns>Decrypted value. </returns>
        public void Decrypt(string InputFile, string OutputFile)
        {

            try
            {
                if ((InputFile != null) && (InputFile.Length > 0))
                {
                    _inputFile = InputFile;
                }
                if ((OutputFile != null) && (OutputFile.Length > 0))
                {
                    _outputFile = OutputFile;
                }
                Transform(null, TransformType.DECRYPT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*****************************************************************
         * Generate an encryption key based on the given phrase.  The 
         * phrase is hashed to create a unique 32 character (256-bit) 
         * value, of which 24 characters (192 bit) are used for the
         * key and the remaining 8 are used for the initialization 
         * vector (IV).
         * 
         * Parameters:  SecretPhrase - phrase to generate the key and 
         * IV from.
         * 
         * Return Val:  None  
         ***************************************************************/
        private void GenerateKey(string SecretPhrase)
        {
            // Initialize internal values
            this._Key = new byte[24];
            this._IV = new byte[16];

            // Perform a hash operation using the phrase.  This will 
            // generate a unique 32 character value to be used as the key.
            byte[] bytePhrase = Encoding.ASCII.GetBytes(SecretPhrase);
            SHA384Managed sha384 = new SHA384Managed();
            sha384.ComputeHash(bytePhrase);
            byte[] result = sha384.Hash;

            // Transfer the first 24 characters of the hashed value to the key
            // and the remaining 8 characters to the intialization vector.
            for (int loop = 0; loop < 24; loop++) this._Key[loop] = result[loop];
            for (int loop = 24; loop < 40; loop++) this._IV[loop - 24] = result[loop];
        }

        /*****************************************************************
         * Transform one form to anoter based on CryptoTransform
         * It is used to encrypt to decrypt as well as decrypt to encrypt
         * Parameters:  input [byte array] - which needs to be transform 
         *              transformType - encrypt/decrypt transform
         * 
         * Return Val:  byte array - transformed value.
         ***************************************************************/
        private byte[] Transform(byte[] input, TransformType transformType)
        {
            CryptoStream cryptoStream = null;      // Stream used to encrypt
            RijndaelManaged rijndael = null;        // Rijndael provider
            ICryptoTransform rijndaelTransform = null;// Encrypting object            
            FileStream fsIn = null;                 //input file
            FileStream fsOut = null;                //output file
            MemoryStream memStream = null;          // Stream to contain data
            try
            {
                // Create the crypto objects
                rijndael = new RijndaelManaged();
                rijndael.Key = this._Key;
                rijndael.IV = this._IV;
                if (transformType == TransformType.ENCRYPT)
                {
                    rijndaelTransform = rijndael.CreateEncryptor();
                }
                else
                {
                    rijndaelTransform = rijndael.CreateDecryptor();
                }

                if ((input != null) && (input.Length > 0))
                {
                    memStream = new MemoryStream();
                    cryptoStream = new CryptoStream(
                         memStream, rijndaelTransform, CryptoStreamMode.Write);

                    cryptoStream.Write(input, 0, input.Length);

                    cryptoStream.FlushFinalBlock();

                    return memStream.ToArray();

                }
                else if ((_inputFile.Length > 0) && (_outputFile.Length > 0))
                {
                    // First we are going to open the file streams 
                    fsIn = new FileStream(_inputFile,
                                FileMode.Open, FileAccess.Read);
                    fsOut = new FileStream(_outputFile,
                                FileMode.OpenOrCreate, FileAccess.Write);

                    cryptoStream = new CryptoStream(
                        fsOut, rijndaelTransform, CryptoStreamMode.Write);

                    // Now will will initialize a buffer and will be 
                    // processing the input file in chunks. 
                    // This is done to avoid reading the whole file (which can be
                    // huge) into memory. 
                    int bufferLen = 4096;
                    byte[] buffer = new byte[bufferLen];
                    int bytesRead;
                    do
                    {
                        // read a chunk of data from the input file 
                        bytesRead = fsIn.Read(buffer, 0, bufferLen);
                        // Encrypt it 
                        cryptoStream.Write(buffer, 0, bytesRead);

                    } while (bytesRead != 0);

                    cryptoStream.FlushFinalBlock();
                }
                return null;

            }
            catch (CryptographicException)
            {
                throw new CryptographicException("Password is invalid. Please verify once again.");
            }
            finally
            {
                if (rijndael != null) rijndael.Clear();
                if (rijndaelTransform != null) rijndaelTransform.Dispose();
                if (cryptoStream != null) cryptoStream.Close();
                if (memStream != null) memStream.Close();
                if (fsOut != null) fsOut.Close();
                if (fsIn != null) fsIn.Close();
            }
        }

    }

    public class RSACryptography
    {
        private const int dwKeySize = 1024;
        private string _publicKey1 = "<RSAKeyValue><Modulus>wotRfwgcc2y17G/zMwWF7Na6mXyzcEkQVWDsZIpeQVKa8eJDAsFBuQ1bG6v5GMztsPqbGCrS3e2EGUQBetEd76UjynCMS9Eit2axNO3CEF8sm5PjMZEoUAb+WsfZwMDW8J4+MEbaiW15IZTo7BmwdjUtsznV4VT1GxtNaifSl+M=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        private string _privateKey = "<RSAKeyValue><Modulus>wotRfwgcc2y17G/zMwWF7Na6mXyzcEkQVWDsZIpeQVKa8eJDAsFBuQ1bG6v5GMztsPqbGCrS3e2EGUQBetEd76UjynCMS9Eit2axNO3CEF8sm5PjMZEoUAb+WsfZwMDW8J4+MEbaiW15IZTo7BmwdjUtsznV4VT1GxtNaifSl+M=</Modulus><Exponent>AQAB</Exponent><P>7q7trFnMLj7GcHSMfLe3YuCu5n9QKBndkN8UhUkcxL6NOP0xqR1oWIGJ2fW+mtIsX0V7lNQ7DNUhiegAov33vQ==</P><Q>0KiX3Mb8f18lV7Sc81EqJLTZEbt9InkPCZnjghB+E9qnvRjY6sY0sUGqDtO1U0PKPR/mBtD5WWHEdSdzDUV4Hw==</Q><DP>rB6BTjRDRWYHe7jQRm/FUwxrk9RjXUepu3rjNWqP0GEJPft4AFgwkwJ3AjJwjPza+qkEgUK6gnp/gQ9IxkEWkQ==</DP><DQ>d0G0skGktOPbgvo+ri6YiKw4WJMxHQ/V0WX8Cy2D8bMKJeDasayhFyJxoNHNlA5tu2vM2956dWSUlWT7s/0dfw==</DQ><InverseQ>3pyWOb9aLYXHXExgGqEHWfQZdSOAz6WxBcljglcIllRYA5GzubTtA1/qaijbaK2DimaKBYfzqcz+5/pixTnkcg==</InverseQ><D>BjH3k2sHtOlGVdQu03YekK852/9rm2zIN1/Rx1XcsInX41IIPkM3O5RgTV5JnW+RNiyU2c0rT+Pra/6NaYLVSCkkOyF/e/qalP1kabFEP2igKACx+ReCVFs1WDK3If3mUV6GgMTVNivqtDnh+qqwzdVos6is9iTYK8rNclbWWTk=</D></RSAKeyValue>";


        public string EncryptString(string inputString)
        {
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(_publicKey1);
            int keySize = dwKeySize / 8;
            byte[] bytes = Encoding.UTF32.GetBytes(inputString);

            int maxLength = keySize - 42;
            int dataLength = bytes.Length;
            int iterations = dataLength / maxLength;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i <= iterations; i++)
            {
                byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
                Buffer.BlockCopy(bytes, maxLength * i, tempBytes, 0, tempBytes.Length);
                byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tempBytes, true);
                Array.Reverse(encryptedBytes);
                stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
            }
            return stringBuilder.ToString();
        }

        public string DecryptString(string inputString)
        {
            // TODO: Add Proper Exception Handlers
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(_privateKey);
            int base64BlockSize = (((dwKeySize / 8) / 3) * 4) + 4;//((dwKeySize / 8) % 3 != 0) ? (((dwKeySize / 8) / 3) * 4) + 4 : ((dwKeySize / 8) / 3) * 4;
            int iterations = inputString.Length / base64BlockSize;
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < iterations; i++)
            {
                byte[] encryptedBytes = Convert.FromBase64String(inputString.Substring(base64BlockSize * i, base64BlockSize));
                Array.Reverse(encryptedBytes);
                arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(encryptedBytes, true));
            }
            return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
        }



    }

    public class MD5HashProperties
    {
        private string _mAC_Address;
        private string _system_ID;
        private string _system_Host;
        private string _school_Security_Code;

        public string MAC_Address
        {
            get { return _mAC_Address; }
            set { _mAC_Address = value; }
        }
        public string SystemID
        {
            get { return _system_ID; }
            set { _system_ID = value; }
        }
        public string SystemHost
        {
            get { return _system_Host; }
            set { _system_Host = value; }
        }
        public string SchoolSecurityCode
        {
            get { return _school_Security_Code; }
            set { _school_Security_Code = value; }
        }
    }
    
    public class MD5Hash
    {
        public string GenerateMD5Hash(MD5HashProperties objMD5HashProperties)
        {
            try
            {

                byte[] bMD5Hash = new MD5CryptoServiceProvider().ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(CreateString(objMD5HashProperties)));
                StringBuilder sOutput = new StringBuilder(bMD5Hash.Length);
                for (int i = 0; i < bMD5Hash.Length; i++)
                {
                    sOutput.Append(bMD5Hash[i].ToString("X2"));
                }
                return sOutput.ToString();


            }
            catch
            {

                return string.Empty;
            }
        }

        public static bool CompareHash(string sHash1, string sHash2)
        {
            return sHash1.Equals(sHash2);
        }
        private static string CreateString(MD5HashProperties objMD5HashProperties)
        {
            StringBuilder sbTemp = new StringBuilder();
            sbTemp.Append(objMD5HashProperties.MAC_Address);
            sbTemp.Append(",");
            sbTemp.Append(objMD5HashProperties.SystemHost);
            sbTemp.Append(",");
            sbTemp.Append(objMD5HashProperties.SystemID);
            sbTemp.Append(",");
            sbTemp.Append(objMD5HashProperties.SchoolSecurityCode);
            return sbTemp.ToString();

            //if (objMD5HashProperties.MAC_Address.Trim() != string.Empty &&
            //    objMD5HashProperties.SchoolSecurityCode.Trim() != string.Empty &&
            //    objMD5HashProperties.SystemHost.Trim() != string.Empty &&
            //    objMD5HashProperties.SystemID.Trim() != string.Empty)
            //{
            //    StringBuilder sbTemp = new StringBuilder();
            //    sbTemp.Append(objMD5HashProperties.MAC_Address);
            //    sbTemp.Append(",");
            //    sbTemp.Append(objMD5HashProperties.SystemHost);
            //    sbTemp.Append(",");
            //    sbTemp.Append(objMD5HashProperties.SystemID);
            //    sbTemp.Append(",");
            //    sbTemp.Append(objMD5HashProperties.SchoolSecurityCode);
            //    return sbTemp.ToString();
            //}
            //else
            //{
            //    throw new Exception("String can not generate.");
            //}

        }


    }
}