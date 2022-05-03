using XTI_TestWebAppApi.Whatever;

namespace XTI_TestWebAppApi;

partial class TestAppApi
{
    private WhateverGroup? _Whatever;

    public WhateverGroup Whatever { get => _Whatever ?? throw new ArgumentNullException(nameof(_Whatever)); }

    partial void createWhateverGroup(IServiceProvider sp)
    {
        _Whatever = new WhateverGroup
        (
            source.AddGroup(nameof(Whatever)),
            sp
        );
    }
}