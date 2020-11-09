using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class DESEncryption: IEncryption
    {
        public String Encrypt(String text)
        {
            Console.WriteLine("Encrypting message using DES");
            return "EncryptedTextDemoDES";
        }
    }
}
