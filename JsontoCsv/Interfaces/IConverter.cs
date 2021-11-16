using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsontoCsv
{
    public interface IConverter
    {
        object Convert(IFileModel file,string separator, Encoding enc);
    }
}
