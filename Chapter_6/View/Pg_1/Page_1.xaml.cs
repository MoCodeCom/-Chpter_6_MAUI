using Chapter_6.Model.Data;
using Chapter_6.View.pg_2;
using Chapter_6.ViewModel.DependencyInjection.UserDI;
using Chapter_6.ViewModel.Interface;

namespace Chapter_6.View.Pg_1;

public partial class Page_1 : ContentPage
{
	public Page_1()
	{
		InitializeComponent();
		lst1.ItemsSource = new VMUserDI()._user.GetAllUser();
	}

    private void Button_Clicked_ImgLst(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page_2());

    }
}