// Generated Code
namespace TestWebApp.ApiControllers;
[Authorize]
public class WhateverController : Controller
{
    private readonly TestAppApi api;
    public WhateverController(TestAppApi api)
    {
        this.api = api;
    }

    [HttpPost]
    public Task<ResultContainer<EmptyActionResult>> DoSomething()
    {
        return api.Group("Whatever").Action<EmptyRequest, EmptyActionResult>("DoSomething").Execute(new EmptyRequest());
    }
}