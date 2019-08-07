using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WideWorldImporters.API.Services
{
    public class Response : IResponse
    {
        public string Message { get; set; }

        public bool DidError { get; set; }

        public string ErrorMessage { get; set; }
        
    }
}
