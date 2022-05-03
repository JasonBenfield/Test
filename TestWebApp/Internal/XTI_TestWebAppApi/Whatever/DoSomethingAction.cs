﻿namespace XTI_TestWebAppApi.Whatever;

public sealed class DoSomethingAction : AppAction<EmptyRequest, EmptyActionResult>
{
    public async Task<EmptyActionResult> Execute(EmptyRequest model)
    {
        Console.WriteLine($"{DateTime.Now:M/dd/yy HH:mm:ss} Doing Something");
        return new EmptyActionResult();
    }
}