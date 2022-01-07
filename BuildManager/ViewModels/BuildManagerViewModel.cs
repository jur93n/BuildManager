using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using BuildManager.Models;

namespace BuildManager.ViewModels
{
    public class BuildManagerViewModel : INotifyPropertyChanged
    {
        private BuildManagerModel _selectedItem;

        public ObservableCollection<BuildManagerModel> ManagerModels { get; set; }
        public BuildManagerModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        public BuildManagerViewModel()
        {
            ManagerModels = new ObservableCollection<BuildManagerModel>
            {
                new BuildManagerModel { TypeOfWork="Зламати стіну", Worker="Міхалич", Duration="Два дні", TotalPrice=200}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
