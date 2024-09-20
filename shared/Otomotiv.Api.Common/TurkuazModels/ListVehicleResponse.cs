using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Api.Common.TurkuazModels
{
    public class Header
    {
        public int RetCode { get; set; }
        public string Message { get; set; }
        public object RecordInfo { get; set; }
    }

    public class ListVehicleResponse
    {
        public Header Header { get; set; }
    }


}
