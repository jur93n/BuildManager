using System.Windows;
using System.ComponentModel;
using BuildManager.ViewModels;
using BuildManager.Data;
using System;

namespace BuildManager.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /*private readonly string PATH = $"{Environment.CurrentDirectory}\\todoDataList.json";
        private BindingList<BuildManagerModel> _buildManagerData;
        private FileIOService _fileIOService;
        */
        public MainWindow()
        {
            InitializeComponent();
        }
        /*
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _fileIOService = new FileIOService(PATH);

            try
            {
                _buildManagerData = _fileIOService.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

            dgBuildManager.ItemsSource = _buildManagerData;
            _buildManagerData.ListChanged += _buildManagerData_ListChanged;
        }

        private void _buildManagerData_ListChanged(object sender, ListChangedEventArgs e)
        {

            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _fileIOService.SaveData(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }*/
    }
}
