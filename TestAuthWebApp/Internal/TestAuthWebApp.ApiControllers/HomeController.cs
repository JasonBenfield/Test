// Generated Code
namespace TestAuthWebApp.ApiControllers;
[Authorize]
public class HomeController : Controller
{
    private readonly TestAuthAppApi api;
    public HomeController(TestAuthAppApi api)
    {
        this.api = api;
    }

    public async Task<IActionResult> Index()
    {
        var result = await api.Group("Home").Action<EmptyRequest, WebViewResult>("Index").Execute(new EmptyRequest());
        return View(result.Data.ViewName);
    }

    [HttpPost]
    public Task<ResultContainer<string>> Login([FromBody] TestAuthLoginRequest model)
    {
        return api.Group("Home").Action<TestAuthLoginRequest, string>("Login").Execute(model);
    }
}