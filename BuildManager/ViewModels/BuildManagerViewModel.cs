using System.ComponentModel;
using System.Runtime.CompilerServices;
using BuildManager.Models;
using BuildManager.Views;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

        //Властивості для робіт
        public string WorkName { get; set; }
        public string WorkerName { get; set; }
        public string DurationName { get; set; }
        public int TotalPriceName { get; set; }

        //Властивості для виділених елементів
        public BuildManagerModel SelectedItem { get; set; }

        #region Створення нових робіт
        private RelayCommand addNewWork;
        public RelayCommand AddNewWork
        {
            get
            {
                return addNewWork ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window; 
                    string resultStr = "";
                    if (WorkName == null || WorkName.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "NameBlock");
                    }
                    if (WorkerName == null || WorkerName.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "WorkerBlock");
                    }
                    if (DurationName == null || DurationName.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "DurationBlock");
                    }
                    if (TotalPriceName == 0)
                    {
                        SetRedBlockControll(wnd, "TotalPriceBlock");
                    }
                    else
                    {
                        resultStr = DataControl.CreateWork(WorkName, WorkerName, DurationName, TotalPriceName);
                        UpdateAllDataView();
                        ShowMassageToUser(resultStr);
                        SetNullValuesToPropeties();
                        wnd.Close();
                    }
                }
                );
            }
        }
        #endregion

        #region Редагування робіт
        private RelayCommand editWork;
        public RelayCommand EditWork
        {
            get
            {
                return editWork ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string resultStr = "Нічого не вибрано";
                    if (SelectedItem != null)
                    {
                        resultStr = DataControl.EditWork(SelectedItem, 
                            WorkerName, WorkerName, DurationName, TotalPriceName);
                        UpdateAllDataView();
                        SetNullValuesToPropeties();
                        ShowMassageToUser(resultStr);
                        window.Close();
                    }
                    else
                    {
                        ShowMassageToUser(resultStr);
                    }
                }
                );
            }
        }
        #endregion

        #region Видалення робіт
        private RelayCommand deleteItem;
        public RelayCommand DeleteItem
        {
            get
            {
                return deleteItem ?? new RelayCommand(obj =>
                {
                    string resultStr = "Нічого не вибрано";
                    if (SelectedItem != null)
                    {
                        resultStr = DataControl.DeleteWork(SelectedItem);
                        UpdateAllDataView();
                    }
                    SetNullValuesToPropeties();
                    ShowMassageToUser(resultStr);
;                }
                );
            }
        }
        #endregion

        #region Команди відкриття вікон
        private RelayCommand openEditItemWindow;
        public RelayCommand OpenEditItemWindow
        {
            get
            {
                return openEditItemWindow ?? new RelayCommand(obj =>
                {
                    if (SelectedItem != null)
                    {
                        OpenEditNewWorkWindowMethod();
                    }
                }
                );
            }
        }

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

        private void SetRedBlockControll(Window wnd, string blockName)
        {
            Control block = wnd.FindName(blockName) as Control;
            block.BorderBrush = Brushes.Red;
        }

        #region Update Views
        private void SetNullValuesToPropeties()
        {
            WorkName = null;
            WorkerName = null;
            DurationName = null;
            TotalPriceName = 0;
        }
        private void UpdateAllDataView()
        {
            UpdateAllWorksViews();
        }
        private void UpdateAllWorksViews()
        {
            AllBuildManagerModels = DataControl.GetAllBuildManagerModels();
            MainWindow.AllWorksView.ItemsSource = null;
            MainWindow.AllWorksView.Items.Clear();
            MainWindow.AllWorksView.ItemsSource = AllBuildManagerModels;
            MainWindow.AllWorksView.Items.Refresh();
        }
        #endregion

        private void ShowMassageToUser(string message)
        {
            MessageView messageView = new MessageView(message);
            SetCenterPositionAndOpen(messageView);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
