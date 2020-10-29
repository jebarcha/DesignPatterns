using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ImageStorageWithTheProblem
    {
        private String _compressor;
        private String _filter;

        public ImageStorageWithTheProblem(String compressor, String filter)
        {
            this._compressor = compressor;
            this._filter = filter;
        }

        // It is violating the SRP because it is also compressing and applying filter
        // Also is violating OCP because We would have to modify the class to add more options for compressing or filters

        public void store(String fileName) 
        { 
            if (_compressor == "jpeg") 
            {
                Console.WriteLine("Compressing using JPEG");
            } 
            else if (_compressor == "png") 
            {
                Console.WriteLine("Compressing using PNG");
            }

            if (_filter == "b&w") 
            {
                Console.WriteLine("Applying B&W filter");
            }
            else if (_filter == "high-contrast")
            {
                Console.WriteLine("Applying high contrast filter");
            }
        }
    }
}
