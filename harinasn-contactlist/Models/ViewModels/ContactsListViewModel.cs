using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;



namespace harinasn_contactlist.Models.ViewModels
{
   public partial class ContactsListViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Contact> contacts = new();

       
        [ObservableProperty]
        private Contact contact = new();

        [RelayCommand]
        private void Add()
        {
           
            Contacts.Add(Contact);
            Contact = new Contact();
        }
    }
}

//Done by Hari Narayanan
//used ai for debugging