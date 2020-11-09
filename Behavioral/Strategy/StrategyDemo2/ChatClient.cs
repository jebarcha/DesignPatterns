using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ChatClient
    {
        private IEncryption encryptionAlgorithm;
        public ChatClient(IEncryption encryptionAlgorithm)
        {
            this.encryptionAlgorithm = encryptionAlgorithm;
        }
        public void Send(String message)
        {
            var encryptedResult = encryptionAlgorithm.Encrypt(message);

            Console.WriteLine("Sending the encrypted message...");
        }

    }
}
