using ProjectIdeas.ViewModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.Ui;
using Wpf.Ui.Abstractions;
using Wpf.Ui.Controls;

namespace ProjectIdeas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FluentWindow, INavigationWindow
    {
        private readonly INavigationService _navigationService;
        private INavigationViewPageProvider? _pageProvider;
        private IServiceProvider? _serviceProvider;

        public MainWindow(MainWindowViewModel viewModel, INavigationService navigationService)
        {
            InitializeComponent();
            DataContext = viewModel;

            _navigationService = navigationService;

            _navigationService.SetNavigationControl(RootNavigation);
        }

        public void CloseWindow()
        {
            Close();
        }

        public Window GetWindow()
        {
            return this;
        }

        public INavigationView GetNavigation()
        {
            return RootNavigation;
        }

        public bool Navigate(Type pageType)
        {
            return RootNavigation.Navigate(pageType);
        }

        public void SetPageService(INavigationViewPageProvider navigationViewPageProvider)
        {
            _pageProvider = navigationViewPageProvider;
        }

        public void SetServiceProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void ShowWindow()
        {
            Show();
        }
    }
}