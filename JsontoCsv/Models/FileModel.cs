using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsontoCsv
{
    public class FileModel : IFileModel
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
        public object Data { get; set; }
    }
}
