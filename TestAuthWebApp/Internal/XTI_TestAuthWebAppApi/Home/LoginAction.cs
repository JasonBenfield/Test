using XTI_HubAppClient;

namespace XTI_TestAuthWebAppApi.Home;

internal sealed class LoginAction : AppAction<TestAuthLoginRequest, string>
{
    private readonly HubAppClient hubClient;

    public LoginAction(HubAppClient hubClient)
    {
        this.hubClient = hubClient;
    }

    public Task<string> Execute(TestAuthLoginRequest model)
    {
        if (new UnverifiedUser().Verify(model.Password))
        {
            throw new AppException("Password is not correct");
        }
        return hubClient.ExternalAuth.ExternalAuthKey
        (
            "", 
            new ExternalAuthKeyModel
            {
                AppKey = TestAuthInfo.AppKey,
                ExternalUserKey = $"auth_{model.UserName}"
            }
        );
    }
}
