using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class EncryptedCloudStream: IStream
    {
        private IStream stream;
        public EncryptedCloudStream(IStream stream)
        {
            this.stream = stream;
        }

        public void Write(string data)
        {
            var encrypted = Encrypt(data);
            stream.Write(encrypted);
        }

        private String Encrypt(String data) 
        {
            return "234asdf%345346";
        }


    }
}
