using Chapter_6.ViewModel.DependencyInjection.UserGroup;


namespace Chapter_6.View.pg_3;

public partial class GroupUserPage : ContentPage
{
	public GroupUserPage()
	{
		InitializeComponent();
		lst.ItemsSource = new VMUserGroupDI()._user.GetAllUser();
	}
}