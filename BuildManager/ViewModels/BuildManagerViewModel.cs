using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using BuildManager.Models;
using BuildManager.Views;
using BuildManager.Data;
using System.Collections.Generic;
using System.Windows;
using System;

namespace BuildManager.ViewModels
{
    public class BuildManagerViewModel : INotifyPropertyChanged
    {
        private List<BuildManagerModel> allBuildManagerModels = DataControl.GetAllBuildManagerModels();

        public List<BuildManagerModel> AllBuildManagerModels
        {
            get { return allBuildManagerModels; }
            set
            {
                allBuildManagerModels = value;
                OnPropertyChanged("AllBuildManagerModels");
            }
        }

        #region Команди відкриття вікон
        private RelayCommand openAddNewWorkWindow;
        public RelayCommand OpenAddNewWorkWindow
        {
            get
            {
                return openAddNewWorkWindow ?? new RelayCommand(obj =>
                {
                    OpenAddNewWorkWindowMethod();
                }  
                );
            }
        }
        #endregion

        #region Методи відкриття вікон
        private void OpenAddNewWorkWindowMethod()
        {
            AddNewWorkWindow newWorkWindow = new AddNewWorkWindow();
            SetCenterPositionAndOpen(newWorkWindow);
        }

        private void OpenEditNewWorkWindowMethod()
        {
            AddNewWorkWindow editWorkWindow = new AddNewWorkWindow();
            SetCenterPositionAndOpen(editWorkWindow);
        }

        private void SetCenterPositionAndOpen (Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
