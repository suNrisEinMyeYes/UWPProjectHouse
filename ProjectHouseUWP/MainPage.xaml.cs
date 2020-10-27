using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using NavigationView = Windows.UI.Xaml.Controls.NavigationView;
using System.Collections.ObjectModel;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;
using System.Globalization;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace ProjectHouseUWP
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public ObservableCollection<ModelForDGBig> modelForDG;
        private static ObservableCollection<Model> Info;
        private bool ConfirmState = false;

        private static class1.Envelope Model;
        
        public MainPage()
        {
            this.InitializeComponent();
            modelForDG = new ObservableCollection<ModelForDGBig>();
            Model = new class1.Envelope();
            //CommandsToWorkWithDB.xmlFinish += GridFilling;
            DGBig.IsEnabled = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {

            ConnHolder.SetConnStr(@"Data Source=78.140.21.18;Initial Catalog=td010119; User Id=tdmerc; Password=tdmerc123;");
            var info = await CommandsToWorkWithDB.GetProductsAsync();
            Info = info;
            List<Microsoft.UI.Xaml.Controls.NavigationViewItem> navigationViewItems = new List<Microsoft.UI.Xaml.Controls.NavigationViewItem>();
            for (int i = 0; i < info.Count; i++)
            {
                navigationViewItems.Add(new Microsoft.UI.Xaml.Controls.NavigationViewItem { Tag = info[i].NameOfPlace, Content = info[i].NameOfPlace });
            }
            Microsoft.UI.Xaml.Controls.NavigationViewItem Places = new Microsoft.UI.Xaml.Controls.NavigationViewItem();
            Places.Tag = "Places";
            Places.Content = "Площадки";
            Places.MenuItemsSource = navigationViewItems;

            nvSample.MenuItems.Add(Places);
        }

        public void GridFilling(string Place)
        {
            ModelForDGBig DGitem = new ModelForDGBig();
            for (int i = 0; i < Model.Body.ReceiveApplicationResultResponse.Application.Result.GetVetDocumentChangesListResponse.VetDocumentList.Count; i++)
            {
                DGitem.Place = Place;
                DGitem.UID = Model.Body.ReceiveApplicationResultResponse.Application.Result.GetVetDocumentChangesListResponse.VetDocumentList.VetDocument[i].Uuid;
                DGitem.DateDoc = "123";
                DGitem.DocType = "123";
                DGitem.Status = Model.Body.ReceiveApplicationResultResponse.Application.Result.GetVetDocumentChangesListResponse.VetDocumentList.VetDocument[i].VetDStatus;
                DGitem.Sender = "123";
                DGitem.AccompanyingDocs = "123";
                DGitem.ArtT_D = "123";
                DGitem.Shipment = "123";
                DGitem.Check = false;
                modelForDG.Add(DGitem);
                DGitem = new ModelForDGBig();
            }
        }
        private void StateChange()
        {
            if (text1.Visibility == Visibility.Collapsed)
            {
                text1.Visibility = Visibility.Visible;
                text2.Visibility = Visibility.Visible;
                EndDate.Visibility = Visibility.Visible;
                BeginDate.Visibility = Visibility.Visible;
            }
            else
            {
                HttpRest.beginDate = BeginDate.SelectedDate.Value.DateTime;
                HttpRest.endDate = EndDate.SelectedDate.Value.DateTime;
                switch (ComboBoxStatus.SelectedValue)
                {
                    case "Погашен":
                        HttpRest.DocStatus = "UTILIZED";
                        break;
                    case "Подтвержден":
                        HttpRest.DocStatus = "CONFIRMED";
                        break;
                    case "Аннулирован":
                        HttpRest.DocStatus = "WITHDRAWN";
                        break;

                    default:
                        break;
                }
                switch (ComboBoxType.SelectedValue)
                {
                    case "Входящие":
                        HttpRest.DocType = "INCOMING";
                        break;
                    case "Исходящие":
                        HttpRest.DocType = "OUTGOING";
                        break;
                    case "Транспортные":
                        HttpRest.DocType = "TRANSPORT";
                        break;
                    case "Производственные":
                        HttpRest.DocType = "PRODUCTIVE";
                        break;
                    case "Возвратные":
                        HttpRest.DocType = "RETURNABLE";
                        break;
                    default:
                        break;
                }
                text1.Visibility = Visibility.Collapsed;
                text2.Visibility = Visibility.Collapsed;
                text3.Visibility = Visibility.Collapsed;
                text4.Visibility = Visibility.Collapsed;
                ConfirmBtn.Visibility = Visibility.Collapsed;
                EndDate.Visibility = Visibility.Collapsed;
                ComboBoxType.Visibility = Visibility.Collapsed;
                ComboBoxStatus.Visibility = Visibility.Collapsed;
                BeginDate.Visibility = Visibility.Collapsed;
            }
        }

        private async void nvSample_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            
            
            Debug.WriteLine(Windows.Storage.ApplicationData.Current.LocalFolder.Path);
            if (args.IsSettingsSelected)
            {
                contentFrame.Navigate(typeof(Settings));
            }
            else
            {
                Model = null;
                var selectedItem = (Microsoft.UI.Xaml.Controls.NavigationViewItem)args.SelectedItem;
                if (selectedItem != null)
                {
                    string selectedItemTag = ((string)selectedItem.Tag);

                    foreach (var item in Info)
                    {
                        if (item.NameOfPlace == selectedItemTag)
                        {
                            GridRing.IsActive = true;
                            File.Delete(Windows.Storage.ApplicationData.Current.LocalFolder.Path + "\\" + "Out.xml");
                            
                            Model = await CommandsToWorkWithDB.GetXML(item, Info);
                            GridRing.IsActive = false;
                            DGBig.IsEnabled = true;
                            GridFilling(item.NameOfPlace);
                        }
                    }

                }
            }

        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            StateChange();
        }
    }
}
