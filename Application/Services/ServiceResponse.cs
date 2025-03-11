using Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Application.Services;

namespace VMS.Application.Services
{
    public class ServiceResponse<T> : IServiceResponse<T>
    {
        public string Message { get; init; } = string.Empty;

        public bool Success { get; init; }

        public T Data { get; init; }

        public ServiceResponse(string message, bool success, T data)
        {
            Message = message;
            Success = success;
            Data = data;
        }
    }
}
