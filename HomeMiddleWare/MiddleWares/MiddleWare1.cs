using System.Diagnostics;

namespace HomeMiddleWare.MiddleWares;

public class MiddleWare1
{
    private readonly RequestDelegate _next;

    public MiddleWare1(RequestDelegate next)
    {
        _next = next;
    }

    public async Task<string> InvokeAsync(HttpContext context)
    {
        try
        {
            var headReques = context.Request.Headers.ToString();
            var queryParams = context.Request.Query.ToString();
            int statusCode = context.Response.StatusCode;
            string clientIp = context.Connection.RemoteIpAddress.ToString();
            var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var stopwatch = Stopwatch.StartNew();
            Console.WriteLine($"Head of requerst: {headReques}, query parametrs: {queryParams},  status code: {statusCode}, IP:  {clientIp}, Time: {time}");
            await _next(context);
            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"The Request and Response continue {elapsedMs}/ms");
        }
        catch (Exception e)
        {
            Console.WriteLine("Your Error Message: " + e.Message);
            return $"Error {e.Message}";
        }

        return "MiddleWare Work";
    }
}