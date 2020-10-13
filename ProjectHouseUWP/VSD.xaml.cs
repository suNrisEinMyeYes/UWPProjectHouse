using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjectHouseUWP
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class VSD : Page
    {
        private class1.Envelope xml;
        public VSD()
        {
            this.InitializeComponent();
            string text = File.ReadAllText(Windows.Storage.ApplicationData.Current.LocalFolder.Path + "\\" + "Out.xml");
            textblock.Text = text;
        }
        /*
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                xml = (class1.Envelope)e.Parameter;
            }
            
                foreach (var item in xml.Body.ReceiveApplicationResultResponse.Application.Result.GetVetDocumentChangesListResponse.VetDocumentList.VetDocument)
                {
                    test.Text += item.Uuid + "\n";
                }
                
            
            
        }
        */


    }
}
