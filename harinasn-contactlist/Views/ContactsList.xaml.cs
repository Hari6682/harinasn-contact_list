using harinasn_contactlist.Models.ViewModels;
using harinasn_contactlist.Models;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harinasn_contactlist.Views
{
    public partial class ContactsList : ContentPage
    {

        public ContactsList()
        {
            InitializeComponent();
        }

        private void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as harinasn_contactlist.Models.Contact;
            var contactViewModel = new ContactDetailViewModel { Contact = contact };
            var contactDetail = new ContactDetails();
            contactDetail.BindingContext = contactViewModel;
            Navigation.PushAsync(contactDetail);

        }
    }
}

//Done by Hari Narayanan
//used ai for debugging