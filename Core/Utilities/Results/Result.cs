using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)
        {
            Message = message; //constructer yapısında yazılabilir.
        }
        public Result(bool success)
        { //overload
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
