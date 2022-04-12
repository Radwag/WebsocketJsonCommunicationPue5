using System.Windows;
using SampleWpfApp.ViewModels;
using Services;

namespace SampleWpfApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Initialize view model for DataContext
            MainViewModel mainViewModel = new MainViewModel();
            DataContext = mainViewModel;
            CommandBindings.AddRange(mainViewModel.Commands);
        }
    }
}