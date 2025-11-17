using harinasn_contactlist.Views;

namespace harinasn_contactlist

{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

    }
}

//Done by Hari Narayanan
//used ai for debugging