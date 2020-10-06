using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Species.VIewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
