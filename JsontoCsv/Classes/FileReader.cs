using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsontoCsv
{
    public static class FileReader
    {
        public static string Read(string path)
        { 
        return  File.ReadAllText(path);
        }
    }
}
