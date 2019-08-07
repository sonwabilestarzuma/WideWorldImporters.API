using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WideWorldImporters.API.Services
{
    public interface IResponse
    {
        string Message { get; set; }

        bool DidError { get; set; }

        string ErrorMessage { get; set; }
    }

    public interface ISingleResponse<TModel> : IResponse
    {
        TModel Model { get; set; }
    }

    public interface IListResponse<TModel> : IResponse
    {
        IEnumerable<TModel> Model { get; set; }
    }

    public interface IPagedResponse<TModel> : IListResponse<TModel>
    {
        int ItemsCount { get; set; }

        double PageCount { get; }
    }
}

