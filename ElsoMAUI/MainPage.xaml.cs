using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace ElsoMAUI;

public partial class MainPage : ContentPage
{
    private User registeredUser;
    public MainPage()
	{
		InitializeComponent();

        AgeSetup();
        GenderSetup();
	}
    /// <summary>
    /// Feltölti a választható nemekkel
    /// </summary>
    private void GenderSetup()
    {
        pGender.ItemsSource = new List<string>() { "férfi", "nő" };
        pGender.SelectedIndex = 0;
    }

    /// <summary>
    /// Feltölti az engedélyezett életkorokkal
    /// </summary>
    private void AgeSetup()
    {
        pAge.ItemsSource = null;
        pAge.Items.Clear();

        List<int> allowedAges = new List<int>();
        for (int i = 16; i < 60; i++)
        {
            allowedAges.Add(i);
        }

        pAge.ItemsSource = allowedAges;

        pAge.SelectedIndex = 0;
    }
    /// <summary>
    /// Felhasználó példányosítása a regisztráció gombra kattintáskor
    /// </summary>
    private async void btnReg_Clicked(object sender, EventArgs e)
    {
        if (eName.Text == null || eName.Text.Length == 0)
        {
            await DisplayAlert("Figyelmeztetés!", "A név megadása kötelező!", "Rendben");
        }
        else
        {
            registeredUser = new User(eName.Text, (int)pAge.SelectedItem, pGender.SelectedItem.Equals("férfi"));
            await Navigation.PushAsync(new PageRegistered(registeredUser)); //Visszaléphető page
            //await Navigation.PushModalAsync(new PageRegistered(registeredUser)); //Nem visszaléphető page, azaz modal
        }
    }
    
}

