using Brown9mcMVVM2.Models.ViewModels;
using Brown9mcMVVM2.Models;

namespace Brown9mcMVVM2.Views;

public partial class ContactListPage : ContentPage
{
	public ContactListPage()
	{
		InitializeComponent();
	}
	private void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		var contact1 = e.Item as Models.Contact;
		var contactViewModel = new ContactDetailViewModel { Contact = contact1 };
		var contactDetail = new ContactDetailsPage();
		contactDetail.BindingContext = contactViewModel;
		Navigation.PushAsync(contactDetail);
	}
}