// Generated Code
namespace TestWebApp.ApiControllers;
[Authorize]
public class HomeController : Controller
{
    private readonly TestAppApi api;
    public HomeController(TestAppApi api)
    {
        this.api = api;
    }

    public async Task<IActionResult> Index()
    {
        var result = await api.Group("Home").Action<EmptyRequest, WebViewResult>("Index").Execute(new EmptyRequest());
        return View(result.Data.ViewName);
    }
}