using Taxify.Service.Exceptions;
using Taxify.WebApi.Models;

namespace Taxify.WebApi.Middlewares;

public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate _request;
    private readonly ILogger<ExceptionHandlerMiddleware> _logger;

    public ExceptionHandlerMiddleware(RequestDelegate request, ILogger<ExceptionHandlerMiddleware> logger)
    {
        _request = request;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _request.Invoke(context);
        }
        catch (NotFoundException exception)
        {
            context.Response.StatusCode = exception.StatusCode;

            await context.Response.WriteAsJsonAsync(new Response()
            {
                StatusCode = context.Response.StatusCode,
                Message = exception.Message
            });
        }
        catch (AlreadyExistsException exception)
        {
            context.Response.StatusCode = exception.StatusCode;

            await context.Response.WriteAsJsonAsync(new Response()
            {
                StatusCode = context.Response.StatusCode,
                Message = exception.Message
            });
        }
        catch (CustomException exception)
        {
            context.Response.StatusCode = exception.StatusCode;

            await context.Response.WriteAsJsonAsync(new Response()
            {
                StatusCode = context.Response.StatusCode,
                Message = exception.Message
            });
        }
        catch (Exception exception)
        {
            context.Response.StatusCode = 500;
            _logger.LogError(message:exception.ToString());

            await context.Response.WriteAsJsonAsync(new Response()
            {
                StatusCode = context.Response.StatusCode,
                Message = exception.Message
            });
        }
    }
}