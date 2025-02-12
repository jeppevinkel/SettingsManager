using SettingsManager;

namespace ExampleProgram;

public class GameSettings : Setting<GameSettings>
{
    // Audio Settings
    public float MasterVolume { get; set; } = 1.0f;  // Range: 0.0 to 1.0
    public float MusicVolume { get; set; } = 0.8f;   // Range: 0.0 to 1.0
    public float SfxVolume { get; set; } = 1.0f;     // Range: 0.0 to 1.0

    // Mouse Settings
    public float MouseSensitivity { get; set; } = 1.0f;  // Default sensitivity
    public bool InvertMouseY { get; set; } = false;      // Y-axis inversion
    public bool InvertMouseX { get; set; } = false;      // X-axis inversion
}