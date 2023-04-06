namespace ElsoMAUI;

public partial class PageRegistered : ContentPage
{
	private User registeredUser;
	public PageRegistered(User user)
	{
		InitializeComponent();

		registeredUser = user;
		lblUser.Text = registeredUser.ToString();
	}
}