using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RetailChainOfStores.Model.Services
{
    public class MD5Service
    {
        public static string EncodeString(string stringValue)
        {
            byte[] stringValueBytes = new UTF8Encoding().GetBytes(stringValue);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(stringValueBytes);
            string encoded = BitConverter.ToString(hash);
            return encoded;
        }

        public static bool CompareHashStrings(string hash1, string hash2)
        {
            return string.Equals(hash1, hash2); 
        }
    }
}
