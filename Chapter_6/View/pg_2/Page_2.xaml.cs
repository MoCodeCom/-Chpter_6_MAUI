using Chapter_6.Model.Data;
using Chapter_6.ViewModel.DependencyInjection.UserImageDI;

namespace Chapter_6.View.pg_2;

public partial class Page_2 : ContentPage
{
	public Page_2()
	{
		InitializeComponent();
		lst.ItemsSource = new VMUserImageDI()._userImage.GetAllUserImage();
	}

    private void lst_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		UserImage user = (UserImage)e.Item;
		DisplayAlert("User Information",
			$"Full Name: " + user.FirstName + " "+user.LastName  +"\n Address: " +  user.Note,
			"Close");
		((ListView)sender).SelectedItem = null;
    }

    private async void BuyNow_Clicked(object sender, EventArgs e)
    {
		var b = (Button)sender;
		var lst = (UserImage)b.CommandParameter;
		await DisplayAlert("Clicked Button", lst.FirstName.ToString(), "Close");
    }
}