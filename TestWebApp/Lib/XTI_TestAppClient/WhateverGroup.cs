// Generated Code
namespace XTI_TestAppClient;
public sealed partial class WhateverGroup : AppClientGroup
{
    public WhateverGroup(IHttpClientFactory httpClientFactory, XtiTokenAccessor xtiTokenAccessor, AppClientUrl clientUrl) : base(httpClientFactory, xtiTokenAccessor, clientUrl, "Whatever")
    {
    }

    public Task<EmptyActionResult> DoSomething() => Post<EmptyActionResult, EmptyRequest>("DoSomething", "", new EmptyRequest());
}