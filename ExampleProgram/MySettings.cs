using SettingsManager;

namespace ExampleProgram;

public class MySettings : Setting<MySettings>
{
    public string Username { get; set; } = "DefaultName";
    public bool IsRegistered { get; set; } = false;
    public float SomeValue { get; set; } = 0;
    public List<int> Numbers { get; set; } = new();
}