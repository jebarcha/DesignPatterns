using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class AESEncryption : IEncryption
    {
        public String encrypt(String text)
        {
            Console.WriteLine("Encrypting message using AES");
            return "EncryptedTextDemoAES";
        }
    }
}
