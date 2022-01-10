using System.Windows;
using BuildManager.ViewModels;

namespace BuildManager.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new BuildManagerViewModel();
        }
    }
}
