using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsontoCsv
{
    public class FileWriter : IFileWriter
    {
        public void Write(IFileModel file)
        {
            File.WriteAllText(file.FilePath+"\\"+file.Name, (string)file.Data);
        }
    }
}
