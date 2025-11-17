using harinasn_contactlist.Models.ViewModels;
using harinasn_contactlist.Views; 

namespace harinasn_contactlist.Views;

public partial class MainPage : ContentPage
{
    private ContactsListViewModel contactsViewModel;

    public MainPage()
    {
        InitializeComponent();
        contactsViewModel = new ContactsListViewModel();
        BindingContext = contactsViewModel;
    }

   
    private void Button_Clicked(object sender, EventArgs e)
    {
        var contactsPage = new ContactsList();
        contactsPage.BindingContext = contactsViewModel;
        Navigation.PushAsync(contactsPage);
    }
}

//Done by Hari Narayanan
//used ai for debugging