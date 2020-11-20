using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Demo2
{
    public abstract class DataReader
    {
        private DataReader next;
        public void SetNext(DataReader next)
        {
            this.next = next;
        }

        public void Read(String fileName)
        {
            if (fileName.EndsWith(GetExtension()))
            {
                this.DoRead(fileName);
                return;
            }

            if (next != null)
                next.Read(fileName);
            else
                throw new ArgumentException("File format not supported.");
        }

        protected abstract String GetExtension();

        protected abstract void DoRead(String fileName);
    }
}
