using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class WithTheProblem
    {
        private String encryptionAlgorithm;
        public WithTheProblem(String encryptionAlgorithm)
        {
            this.encryptionAlgorithm = encryptionAlgorithm;
        }

        // Here is violating the SRP because it is encrypting the message and also sending the message as well.
        // Also OCP because if we want to add more encryption options would need to modify the class

        public void Send(String message)
        {
            if (encryptionAlgorithm == "DES")
                Console.WriteLine("Encrypting message using DES");
            else if (encryptionAlgorithm == "AES")
                    Console.WriteLine("Encrypting message using AES");
            else
                    throw new Exception("Unsupported encryption algorithm");

            Console.WriteLine("Sending the encrypted message...");
        }

    }
}
