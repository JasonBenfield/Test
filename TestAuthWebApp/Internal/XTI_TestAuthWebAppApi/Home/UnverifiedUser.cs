namespace XTI_TestAuthWebAppApi.Home;

internal sealed class UnverifiedUser
{
    public bool Verify(string password) => password == "Test!";
}
