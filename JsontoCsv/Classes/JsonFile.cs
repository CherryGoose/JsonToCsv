using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsontoCsv
{
    public class JsonFile : IFileModel
    {
        public JsonFile(string inPath, string data)
        {
            Name = Path.GetFileNameWithoutExtension(inPath)+".json";
            FilePath = Path.GetDirectoryName(inPath);
            if(data != "")
            Data = JArray.Parse(data);
        }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public object Data { get; set; }

    }
}
