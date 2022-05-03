using XTI_TestServiceAppApi.Whatever;

namespace XTI_TestServiceAppApi;

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