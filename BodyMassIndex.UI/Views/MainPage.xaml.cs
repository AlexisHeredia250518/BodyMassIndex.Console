using BodyMassIndex.UI.ViewModels;

namespace BodyMassIndex.UI
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

       
    }
}