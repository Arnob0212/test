using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace EmployeeWebApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            // Define the log file path (you can change it as needed)
            var logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "logs.txt");

            // Write exception to file
            File.AppendAllText(logFilePath, $"[{DateTime.Now}] {exception.Message} {Environment.NewLine}");

            // Return 500 response to client
            context.Result = new ObjectResult("Something went wrong on the server.")
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true;
        }
    }
}
