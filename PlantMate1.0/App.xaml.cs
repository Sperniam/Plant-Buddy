namespace PlantMate1._0;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

         try
        {
            MainPage = new MainPage();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Startup error: {ex.Message}");
        }
    }
}