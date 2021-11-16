using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsontoCsv
{
    public class Factory
    {
        public static IFileModel CreateJsonFile(string inPath, string data)
        {
            return new JsonFile(inPath, data);
        }
        public static IFileModel CreateCsvFile(string inPath, string data)
        {
            return new CsvFile(inPath, data);
        }
        public static IConverter CreateConverter()
        {
            return new JsonToCsvConverter();
        }
        public static IFileWriter CreateWriter()
        {
            return new FileWriter();
        }

    }
}
