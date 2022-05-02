namespace XTI_TestServiceAppApi.Whatever;

public sealed class WhateverGroup : AppApiGroupWrapper
{
    public WhateverGroup(AppApiGroup source, IServiceProvider sp)
        : base(source)
    {
        var actions = new AppApiActionFactory(source);
        DoSomething = source.AddAction(actions.Action(nameof(DoSomething), () => sp.GetRequiredService<DoSomethingAction>()));
    }

    public AppApiAction<EmptyRequest, EmptyActionResult> DoSomething { get; }
}