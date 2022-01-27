using BuildManager.Models;
using BuildManager.ViewModels;
using System.Windows;

namespace BuildManager.Views
{
    /// <summary>
    /// Логика взаимодействия для EditWorkWindow.xaml
    /// </summary>
    public partial class EditWorkWindow : Window
    {
        public EditWorkWindow(BuildManagerModel workToEdit)
        {
            InitializeComponent();
            DataContext = new BuildManagerViewModel();
            BuildManagerViewModel.SelectedItem = workToEdit;
            BuildManagerViewModel.WorkName = workToEdit.TypeOfWork;
            BuildManagerViewModel.WorkerName = workToEdit.Worker;
            BuildManagerViewModel.DurationName = workToEdit.Duration;
            BuildManagerViewModel.TotalPriceName = workToEdit.TotalPrice;
        }
    }
}
