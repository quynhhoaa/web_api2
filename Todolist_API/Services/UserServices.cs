using System.Security.Claims;

namespace Todolist_API.Services
{
    public class UserServices : IUserServices
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public UserServices(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public string GetMyName()
        {
            var result = string.Empty;
            if (_contextAccessor.HttpContext != null)
            {
                result = _contextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;

        }

    }
}
