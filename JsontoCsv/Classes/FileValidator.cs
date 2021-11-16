using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsontoCsv
{
    public class Validator
    {
        public static bool ValidateFile(string filePath)
        {
            return File.Exists(Path.GetFullPath(filePath));
        }

        public static bool ValidateDirectory(string filePath)
        {
            return Directory.Exists(filePath);
        }
    }
}
