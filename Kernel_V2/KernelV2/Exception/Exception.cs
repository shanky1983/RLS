using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;
using Attune.KernelV2.Utilities;

namespace Attune.KernelV2
{
    //public class ItemNotFoundException : Exception
    //{
    //    public ItemNotFoundException(string message)
    //        : base(message)
    //    {

    //    }
    //    public ItemNotFoundException(string message, Exception ex)
    //        : base(message, ex)
    //    {

    //    }
    //}
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            ErrorCodes _reasonPharse=0;
            if (context.Exception is ArgumentNullException)
            {
                _reasonPharse = ErrorCodes.ArgumentNullException;
            }
            else if (context.Exception is IOException)
            {
                _reasonPharse = ErrorCodes.IOException;
            }
            else if (context.Exception is ArrayTypeMismatchException)
            {
                _reasonPharse = ErrorCodes.ArrayTypeMismatchException;
            }
            else if (context.Exception is DivideByZeroException)
            {
                _reasonPharse = ErrorCodes.DivideByZeroException;
            }
            else if (context.Exception is InvalidCastException)
            {
                _reasonPharse = ErrorCodes.InvalidCastException;
            }
            else if (context.Exception is OutOfMemoryException)
            {
                _reasonPharse = ErrorCodes.OutOfMemoryException;
            }
            else if (context.Exception is StackOverflowException)
            {
                _reasonPharse = ErrorCodes.StackOverflowException;
            }
            else if (context.Exception is InvalidOperationException)
            {
                _reasonPharse = ErrorCodes.InvalidOperationException;
            }
            else if (context.Exception is FileNotFoundException)
            {
                _reasonPharse = ErrorCodes.FileNotFoundException;
            }
            else if (context.Exception is SqlException && context.Exception.Message.Contains("Could not find stored procedure"))
            {
                _reasonPharse = ErrorCodes.SqlProcedureNotfound;
            }
            else if (context.Exception is SqlException && context.Exception.Message.Contains("expects parameter"))
            {
                _reasonPharse = ErrorCodes.SqlParamMismatch;
            }
            else if (context.Exception is SqlException && context.Exception.Message.Contains("Error converting data type"))
            {
                _reasonPharse = ErrorCodes.SqlDataTypeMismatch;
            }
            else if (context.Exception is AuthorizationException)
            {
                _reasonPharse = ErrorCodes.AuthorizationFailure;
            }
            var result = new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                Content = new StringContent("{\"error\":\"" + Convert.ToInt64(_reasonPharse)+"\"}"),
                ReasonPhrase =Convert.ToInt64(_reasonPharse).ToString()
            };
        
            throw new HttpResponseException(result);
            
        }
    }

    public class AuthorizationException : Exception
    {
        public AuthorizationException(string message)
            : base(message)
        {

        }
        public AuthorizationException(string message, Exception ex)
            : base(message, ex)
        {

        }

    }

    public class UnhandledExceptionLogger : ExceptionLogger
    {
        public override void Log(ExceptionLoggerContext context)
        {
            string _uri = context.Request.RequestUri.AbsoluteUri;
            string _method = context.Request.Method.Method;
            string _message = context.Exception.Message;
            Task<string> _param = context.Request.Content.ReadAsStringAsync();
            CLogger.LogError("Error in " + _uri + " Method:" + _method + " Message:"
                + _message + " Parameters:" + _param.Result, null);

        }
    }



    public enum ErrorCodes
    {
        AuthorizationFailure = 90000,
        ArgumentNullException = 90001,
        IOException = 90002,
        ArrayTypeMismatchException = 90003,
        DivideByZeroException = 90004,
        InvalidCastException = 90005,
        OutOfMemoryException = 90006,
        StackOverflowException = 90007,
        InvalidOperationException = 90008,
        FileNotFoundException = 90009,
        SqlProcedureNotfound = 90010,
        SqlParamMismatch = 90011,
        SqlDataTypeMismatch = 90012
    }
}