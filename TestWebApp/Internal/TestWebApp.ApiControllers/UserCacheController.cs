// Generated Code
namespace TestWebApp.ApiControllers;
[Authorize]
public class UserCacheController : Controller
{
    private readonly TestAppApi api;
    public UserCacheController(TestAppApi api)
    {
        this.api = api;
    }

    [HttpPost]
    public Task<ResultContainer<EmptyActionResult>> ClearCache([FromBody] string model)
    {
        return api.Group("UserCache").Action<string, EmptyActionResult>("ClearCache").Execute(model);
    }
}