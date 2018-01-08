using System;
namespace Marketplace.API.CrossCutting.Exceptions
{
    public static class ExceptionHelper
    {
        public static object ProcessError(Exception ex)
        {
            return new
            {
                error = new
                {
                    code = ex.HResult,
                    message = ex.Message
                }
            };
        }
    }
}
