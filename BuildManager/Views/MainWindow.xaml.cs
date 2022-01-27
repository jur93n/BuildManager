using System.Windows;
using System.Windows.Controls;
using BuildManager.ViewModels;

namespace BuildManager.Views
{
    public partial class MainWindow : Window
    {
        public static ListView AllWorksView;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new BuildManagerViewModel();
            AllWorksView = ViewAllWorks;
        }
    }
}
