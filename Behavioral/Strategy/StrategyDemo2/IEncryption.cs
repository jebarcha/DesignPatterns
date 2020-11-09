using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IEncryption
    {
        public String Encrypt(String text);
    }
}
