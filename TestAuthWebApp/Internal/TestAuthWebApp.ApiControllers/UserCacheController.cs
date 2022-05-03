// Generated Code
namespace TestAuthWebApp.ApiControllers;
[Authorize]
public class UserCacheController : Controller
{
    private readonly TestAuthAppApi api;
    public UserCacheController(TestAuthAppApi api)
    {
        this.api = api;
    }

    [HttpPost]
    public Task<ResultContainer<EmptyActionResult>> ClearCache([FromBody] string model)
    {
        return api.Group("UserCache").Action<string, EmptyActionResult>("ClearCache").Execute(model);
    }
}