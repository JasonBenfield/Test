using XTI_App.Abstractions;
using XTI_HubAppClient;
using XTI_TestAuthWebAppApi;

namespace TestAuthSetupApp;

internal sealed class TestAuthAppSetup : IAppSetup
{
    private readonly HubAppClient hubClient;

    public TestAuthAppSetup(HubAppClient hubClient)
    {
        this.hubClient = hubClient;
    }

    public async Task Run(AppVersionKey versionKey)
    {
        var app = await hubClient.Apps.GetAppByAppKey(new GetAppByAppKeyRequest { AppKey = TestAuthInfo.AppKey });
        await hubClient.Authenticators.RegisterAuthenticator(app.ModKey);
        var systemUser = await hubClient.UserInquiry.GetUserByUserName
        (
            AppUserName.SystemUser(TestAuthInfo.AppKey, Environment.MachineName).Value
        );
        await hubClient.Install.SetUserAccess
        (
            new SetUserAccessRequest
            {
                UserID = systemUser.ID,
                RoleAssignments = new[]
                {
                    new SetUserAccessRoleRequest
                    {
                        AppKey = AppKey.WebApp(hubClient.AppName),
                        RoleNames = new []
                        {
                            new AppRoleName(hubClient.RoleNames.Authenticator)
                        }
                    }
                }
            }
        );
        var userID = await hubClient.Users.AddOrUpdateUser
        (
            new AddUserModel
            {
                UserName = "test.user",
                Password = "Test123456",
                PersonName = "Test User",
                Email = "test.user@xartogg.com"
            }
        );
        await hubClient.Authenticators.RegisterUserAuthenticator
        (
            app.ModKey,
            new RegisterUserAuthenticatorRequest
            {
                UserID = userID,
                ExternalUserKey = "auth_test.user"
            }
        );
    }
}
