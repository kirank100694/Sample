using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Day24Concepts
{
    public class CustomMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hellow from new file 1 \n");

            await next(context);

            await context.Response.WriteAsync("Hellow from new file 2 \n");
        }
    }
}
