using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsontoCsv
{
    public class JsonToCsvConverter : IConverter
    {
        public object Convert(IFileModel file, string separator, Encoding enc) 
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            string result = "";
            if (file.Data != null)
            {

                JArray jarr = (JArray)file.Data;

                foreach (JObject obj in jarr.Children<JObject>())// first level objects
                {
                    foreach (JProperty singleProp in obj.Properties()) // first level object properties
                    {
                        names.TryAdd(singleProp.Name, singleProp.Name);
                    }
                }

                foreach (object obj in names.Values)
                {
                    result += obj.ToString() + separator;
                }
                result = result.Remove(result.Length - 1, 1);
               
            }
            byte[] crutch = enc.GetBytes(result);

            return enc.GetString(crutch);
        }

    }
}
