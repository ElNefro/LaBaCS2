using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBaCS2
{
    public interface IExportable
    {
        string ExportToJson();
        string ExportToXml();

    }
}
