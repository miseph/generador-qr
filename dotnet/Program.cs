internal static class Program
{
    // Aquí es donde por fin podemos poner el atributo
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}