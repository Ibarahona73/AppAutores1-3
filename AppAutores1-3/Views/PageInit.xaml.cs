namespace AppAutores1_3.Views;

public partial class PageInit : ContentPage
{
    readonly Controllers.AuthorControllers authorDB;

    public PageInit()
	{		
        InitializeComponent();
        
    }

    private async void btnprocesar_Clicked(object sender, EventArgs e)
    {
        try
        {
            var author = new Models.AuthorModel
            {
                Nombre = NomAutor.Text,
                Pais = nacionalidad.Text
            };

            if (await App.Database.StoreAuthor(author) > 0)
            {
                await DisplayAlert("Aviso", "Registro ingresado con éxito!!", "OK");
            }
        }
        catch (Exception ex)
        {
            // Log or display the exception details
            Console.WriteLine($"Exception: {ex}");
            await DisplayAlert("Error", "An error occurred. Please try again.", "OK");
        }
    }
}
