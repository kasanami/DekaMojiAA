namespace DekaMojiAAMaker;

internal sealed class Program
{
    private static void Main(string[] args)
    {
        ConsoleApp.Run<DekaMojiAAMakerConsoleApp>(args);
    }
}

internal sealed class DekaMojiAAMakerConsoleApp : ConsoleAppBase
{
    [RootCommand]
    public void Run()
    {
        Console.WriteLine("AAAAAAAA");
    }
}