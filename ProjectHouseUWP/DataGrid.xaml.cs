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
                var info = await GetProductsAsync(ConnHolder.GetConnStr());

                foreach (var item in info)
                {
                    Info.Add(item);
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

        private async Task<ObservableCollection<Model>> GetProductsAsync(string connectionString)
        {
            const string GetProductsQuery = "Select S.CodM,M.Master,S.CodB,K.Title,S.Login,S.Passw,S.GUID,S.GUIDP,S.APIKey,S.AppID,S.Initiator,S.Name" +
          " From Merc_xs S,Master M, Skls K" +
          " Where S.CodM = M.CodM and S.CodB = K.Skl and S.Login <> '' and S.Passw <> '' and S.GUID <> '' and S.GUIDP <> '' and S.APIKey <> ''" +
          " Order by M.Master,K.Title";


            var products = new ObservableCollection<Model>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    if (conn.State == ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetProductsQuery;
                            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                            {
                                while (await reader.ReadAsync())
                                {
                                    var product = new Model();
                                    
                                    product.CodeFil = reader.GetInt16(0);
                                    product.Master = SafeGetString(reader, 1);
                                    product.CodePred = reader.GetInt16(2);
                                    product.Title = SafeGetString(reader, 3);
                                    product.APILogin = SafeGetString(reader, 4);
                                    product.APIPass = SafeGetString(reader, 5);
                                    product.CompanyGuid = SafeGetString(reader, 6);
                                    product.PlaceGuid = SafeGetString(reader, 7);
                                    product.APIKey = SafeGetString(reader, 8);
                                    product.AppId = SafeGetString(reader, 9);
                                    product.User = SafeGetString(reader, 10);
                                    product.NameOfPlace = SafeGetString(reader, 11);
                                    products.Add(product);
                                }
                            }
                        }
                    }
                }
                return products;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
        }

        private static string SafeGetString(SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
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

        private async void XMLBtn_Click(object sender, RoutedEventArgs e)
        {
            var item = (Model)TestDataGrid.SelectedItem;
            var response = await HttpRest.InfoPostAsync(IenumerationPaths.PostFirstTime, item);
            Debug.WriteLine(response);
            
            var filledModel = XmlParser.Desirialize(response);
            
            if (filledModel.Body.submitApplicationResponse != null)
            {
                if(filledModel.Body.submitApplicationResponse.application.status == "ACCEPTED")
                {
                    foreach (var elem in Info)
                    {
                        if (elem == (Model)TestDataGrid.SelectedItem)
                        {
                            elem.AppId = filledModel.Body.submitApplicationResponse.application.applicationId;
                            var Query = $"Update Merc_xs set AppID=\'{elem.AppId}\' where CodM= {elem.CodeFil} and CodB= {elem.CodePred}";
                            await ConnHolder.NonQueryAsyncConnect(Query);
                            Debug.WriteLine("Updated");
                        }
                    }
                    // = filledModel.Body.submitApplicationResponse.application.applicationId;
                    var xml = XmlParser.DesirializeBig(await HttpRest.InfoPostAsync(IenumerationPaths.PostToCheck, item));
                    while (xml.Body.ReceiveApplicationResultResponse.Application.Status == "IN_PROCESS")
                    {
                        xml = XmlParser.DesirializeBig(await HttpRest.InfoPostAsync(IenumerationPaths.PostToCheck, item));
                    }
                    XmlParser.Serialize(xml);
                    contentFrame.Navigate(typeof(VSD), xml);
                    /*ContentDialog dialog = new ContentDialog()
                    {
                        Title = "OK",
                        Content = xml.Body.ReceiveApplicationResultResponse.Application.Status,
                        PrimaryButtonText = "ОК",
                    };
                    await dialog.ShowAsync();
                    */
                }
            }
            else
            {

                ContentDialog dialog = new ContentDialog()
                {
                    Title = "Error",
                    Content = "Failed to parse answer. This may means, you send wrong data or XML file is damaged.",
                    PrimaryButtonText = "ОК",
                };
                await dialog.ShowAsync();
                
            }

            //



        }
    }


}
