using Brown9mcMVVM2.Views;

namespace Brown9mcMVVM2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new HomePage());
        }
    }
}