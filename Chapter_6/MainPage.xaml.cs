using Chapter_6.View.Pg_1;
using Chapter_6.View.pg_3;

namespace Chapter_6;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked_P1(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page_1());
    }

    private void Button_Clicked_Group(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GroupUserPage());
    }
}

