namespace AppAutores1_3;

public partial class App : Application
{
    static Controllers.AuthorControllers database;

    // Create the database connection as a singleton.
    public static Controllers.AuthorControllers Database
    {
        get
        {
            if (database == null)
            {
                database = new Controllers.AuthorControllers();
            }
            return database;
        }
    }
    public App()
    {
        InitializeComponent();

        //MainPage = new NavigationPage(new Views.PageListPersonas());
        MainPage = new AppShell();
    }
}

