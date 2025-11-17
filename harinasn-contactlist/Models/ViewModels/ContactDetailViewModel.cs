using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace harinasn_contactlist.Models.ViewModels
{
    partial class ContactDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        private Contact contact;
    }
}


//Done by Hari Narayanan
//used ai for debugging