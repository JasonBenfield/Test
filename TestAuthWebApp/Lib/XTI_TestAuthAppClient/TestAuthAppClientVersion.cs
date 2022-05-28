// Generated Code
namespace XTI_TestAuthAppClient;
public sealed class TestAuthAppClientVersion
{
    public static TestAuthAppClientVersion Version(string value) => new TestAuthAppClientVersion(value);
    public TestAuthAppClientVersion(IHostEnvironment hostEnv) : this(getValue(hostEnv))
    {
    }

    private static string getValue(IHostEnvironment hostEnv)
    {
        string value;
        if (hostEnv.IsProduction())
        {
            value = "V3";
        }
        else
        {
            value = "Current";
        }

        return value;
    }

    private TestAuthAppClientVersion(string value)
    {
        Value = value;
    }

    public string Value { get; }
}