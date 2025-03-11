using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IServiceResponse<T>
    {
        string Message { get; }
        bool Success { get; }
        T Data { get; }
    }
}
