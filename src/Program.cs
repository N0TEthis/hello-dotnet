u```csharp
using System.Reflection;
using System.Runtime.InteropServices;
using HelloDotnet;

// Версия читается из атрибута сборки.
// Она задаётся в HelloDotnet.csproj через <Version>.
var version = Assembly.GetExecutingAssembly()
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
    .InformationalVersion
    .Split('+')[0] ?? "unknown";

Console.WriteLine($"hello-dotnet version {version}");
Console.WriteLine("Hello from C# in GitHub Actions! 🚀📦");
Console.WriteLine($"OS: {RuntimeInformation.OSDescription}");
Console.WriteLine($"Arch: {RuntimeInformation.OSArchitecture}");
Console.WriteLine(Greeting.Greet("GitHub"));
Console.WriteLine($"Sum 1..10 = {Greeting.SumRange(1, 10)}");

if (args.Length > 0)
{
    Console.WriteLine("Аргументы:");

    for (int i = 0; i < args.Length; i++)
    {
        Console.WriteLine($"  {i + 1}: {args[i]}");
    }
}

// При запуске Windows .exe двойным кликом
// оставляем окно открытым, чтобы пользователь увидел результат.
// В PowerShell / терминале это также безопасно.
if (OperatingSystem.IsWindows())
{
    Console.WriteLine();
    Console.WriteLine("Нажмите Enter для выхода...");
    Console.ReadLine();
}

return 0;
```
