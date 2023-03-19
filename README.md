# SettingsManager
Simple settings manager to easily and quickly store/retrieve json settings files from local appdata.

## Usage

```csharp
// Let's grab the instance to make referencing it easier!
var mySettings = MySettings.Instance;

// Here we just print out the values to show them persisting.
Console.WriteLine($"Username: {mySettings.Username}");
Console.WriteLine($"IsRegistered: {mySettings.IsRegistered}");
Console.WriteLine($"SomeValue: {mySettings.SomeValue}");

Console.WriteLine("Numbers:");
foreach (var number in mySettings.Numbers)
{
    Console.WriteLine($"   - {number}");
}

if (!mySettings.IsRegistered)
{
    // Now set some new values to see the difference!
    Console.Write("Please choose a username: ");
    var newUsername = Console.ReadLine();
    mySettings.Username = newUsername;
    mySettings.IsRegistered = true;
    mySettings.SomeValue = 1.3f;
    
    mySettings.Numbers.Add(1);
    mySettings.Numbers.Add(3);
    mySettings.Numbers.Add(3);
    mySettings.Numbers.Add(7);
    
    MySettings.Save();
}
```
