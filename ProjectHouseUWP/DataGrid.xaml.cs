using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjectHouseUWP
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class DataGrid : Page, INotifyPropertyChanged
    {

        private ObservableCollection<Model> Info;

        public DataGrid()
        {
            this.InitializeComponent();
            Info = new ObservableCollection<Model>();
        }
        private async void OnPageLoaded(object sender, RoutedEventArgs e)
        {
            //TestDataGrid.MaxWidth = DataGrid.ActualWidthProperty;
            try
            {
                var info = await CommandsToWorkWithDB.GetProductsAsync();

                if (info != null)
                {
                    foreach (var item in info)
                    {
                        Info.Add(item);
                    }
                }
                else
                {
                    ContentDialog dialog = new ContentDialog()
                    {
                        Title = "DataBase connection problem.",
                        Content = "No data from Database provided, please login into db",
                        PrimaryButtonText = "ОК",
                    };
                    await dialog.ShowAsync();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        

        private async void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in Info)
            {
                var Query = $"Update Merc_xs set Name=\'{item.NameOfPlace}\', Login = \'{item.APILogin}\', Passw = \'{item.APIPass}\', GUID = \'{item.CompanyGuid}\', GUIDP = \'{item.PlaceGuid}\', Initiator = \'{item.User}\', APIKey = \'{item.APIKey}\' where CodM= {item.CodeFil} and CodB= {item.CodePred}";
                await ConnHolder.NonQueryAsyncConnect(Query);
            }
          
        }

        private async void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = (Model)TestDataGrid.SelectedItem;

            var Query = $"Delete from Merc_xs where S.CodM={item.CodeFil} and S.CodM={item.CodePred}S";
            await ConnHolder.NonQueryAsyncConnect(Query);
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

            Info.Add(new Model());
        }

        private async void TestDataGrid_RowEditEnding(object sender, Microsoft.Toolkit.Uwp.UI.Controls.DataGridRowEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                Model item = e.Row.DataContext as Model;
                var Query = $"Update Merc_xs set Name=\'{item.NameOfPlace}\', Login = \'{item.APILogin}\', Passw = \'{item.APIPass}\', GUID = \'{item.CompanyGuid}\', GUIDP = \'{item.PlaceGuid}\', Initiator = \'{item.User}\', APIKey = \'{item.APIKey}\' where CodM= {item.CodeFil} and CodB= {item.CodePred}";
                await ConnHolder.NonQueryAsyncConnect(Query);
                //Debug.WriteLine(item.NameOfPlace);
            }
        }

        private void XMLBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = (Model)TestDataGrid.SelectedItem;
            var xml = CommandsToWorkWithDB.GetXML(item, Info);
            contentFrame.Navigate(typeof(VSD), xml);

        }
    }


}
