using System.Collections.Generic;

namespace IzinModulCommon.ResultModels
{
    public class Result<T> : IResult // IResult interface'i projenizde tanımlanmış olmalıdır.
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T ?Data { get; set; }
        public int TotalCount { get; set; }

        public Result()
        {
        }

        public Result(bool isSuccess, string message, T data, int totalCount = 0)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
            TotalCount = totalCount;
        }
    }
}
