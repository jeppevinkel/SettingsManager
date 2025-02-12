using ExampleProgram;

// Get the settings instance
var settings = GameSettings.Instance;

// Display current settings
Console.WriteLine("Current Game Settings:");
Console.WriteLine($"Master Volume: {settings.MasterVolume * 100}%");
Console.WriteLine($"Music Volume: {settings.MusicVolume * 100}%");
Console.WriteLine($"SFX Volume: {settings.SfxVolume * 100}%");
Console.WriteLine($"Mouse Sensitivity: {settings.MouseSensitivity}x");
Console.WriteLine($"Invert Y-Axis: {settings.InvertMouseY}");
Console.WriteLine($"Invert X-Axis: {settings.InvertMouseX}");

// Example of modifying settings
Console.WriteLine("\nModifying settings...");

// Adjust volume (50% master volume)
settings.MasterVolume = 0.5f;

// Set mouse sensitivity to 1.5x
settings.MouseSensitivity = 1.5f;

// Enable inverted Y-axis controls
settings.InvertMouseY = true;

// Save the changes
GameSettings.Save();

Console.WriteLine("\nSettings saved! New values:");
Console.WriteLine($"Master Volume: {settings.MasterVolume * 100}%");
Console.WriteLine($"Mouse Sensitivity: {settings.MouseSensitivity}x");
Console.WriteLine($"Invert Y-Axis: {settings.InvertMouseY}");