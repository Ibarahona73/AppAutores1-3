namespace AppAutores1_3.Views;

public partial class AuthorList : ContentPage
{
	public AuthorList()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {

    }

    private void listauthor_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listauthor.ItemsSource = await App.Database.GetListAuthor();
    }
}