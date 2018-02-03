using Prism.Navigation;

namespace WhatsAppSpy.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _whatsAppUrl;
        public string WhatsAppUrl
        {
            get => _whatsAppUrl;
            set => SetProperty(ref _whatsAppUrl, value);
        }
        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Test";
        }
    }
}
