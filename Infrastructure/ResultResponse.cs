using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class ResultResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }


        public ResultResponse(string message)
        {
            Message = message;
        }

        public ResultResponse()
        {
            Success = true;
        }

    }
}
