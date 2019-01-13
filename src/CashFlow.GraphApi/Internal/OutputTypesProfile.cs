using AutoMapper;
using CashFlow.GraphApi.Schema;
using Models = CashFlow.Query.Abstractions.Models;

namespace CashFlow.GraphApi
{
    internal sealed class OutputTypesProfile : Profile
    {
        public OutputTypesProfile()
        {
            CreateMap<Models.Account, Account>();
            CreateMap<Models.Code, Code>();
            CreateMap<Models.Supplier, Supplier>();
        }
    }
}
