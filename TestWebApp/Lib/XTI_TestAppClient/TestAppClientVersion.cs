// Generated Code
namespace XTI_TestAppClient;
public sealed class TestAppClientVersion
{
    public static TestAppClientVersion Version(string value) => new TestAppClientVersion(value);
    public TestAppClientVersion(IHostEnvironment hostEnv) : this(getValue(hostEnv))
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

    private TestAppClientVersion(string value)
    {
        Value = value;
    }

    public string Value { get; }
}