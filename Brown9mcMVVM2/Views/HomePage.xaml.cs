using Brown9mcMVVM2.Models.ViewModels;
using Microsoft.Maui.ApplicationModel.Communication;

namespace Brown9mcMVVM2.Views;

public partial class HomePage : ContentPage
{
    private ContactListViewModel contactsViewModel;
	public HomePage()
	{
		InitializeComponent();
        contactsViewModel = new ContactListViewModel();
        BindingContext = contactsViewModel;
	}
    private void Button_Clicked(object? sender, EventArgs e)
    {
        var contactList = new ContactListPage();
        contactList.BindingContext = contactsViewModel;
        Navigation.PushAsync(contactList);
    }
}