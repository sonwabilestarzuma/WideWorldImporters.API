using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WideWorldImporters.API.Services
{
    public class SingleResponse<TModel> : ISingleResponse<TModel>
    {
        public string Message { get; set; }

        public bool DidError { get; set; }

        public string ErrorMessage { get; set; }

        public TModel Model { get; set; }
    }
}
