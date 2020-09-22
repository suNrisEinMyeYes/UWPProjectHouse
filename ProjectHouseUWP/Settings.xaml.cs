using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
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
    public sealed partial class Settings : Page
    {
        public Settings()
        {
            this.InitializeComponent();
        }
        public void SaveConStr()
        {
            var connectionString = @"Data Source=" + Server.Text + ";Initial Catalog=" + DBName.Text + "; User Id=" + Login.Text + "; Password=" + Password.Password + ";";
            ConnHolder.SetConnStr(connectionString);
        }
        private static bool IsEnterKeyDown()
        {
            var ctrlState = CoreWindow.GetForCurrentThread().GetKeyState(VirtualKey.Enter);
            return (ctrlState & CoreVirtualKeyStates.Down) == CoreVirtualKeyStates.Down;
        }
        private async void Save_Click(object sender, RoutedEventArgs e)
        {
            ProgRing.IsActive = true;
            SaveConStr();
            //Flag should be true if successful connect
            try
            {
                var tempFlag =await ConnHolder.CheckConAsync();
                if (tempFlag)
                {
                    
                    SuccessBlock.Text = "Successful";
                }
                else
                {
                    
                    SuccessBlock.Text = "Failed";
                }
                ProgRing.IsActive = false;
                SuccessBlock.Visibility = Visibility.Visible;
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private async void Grid_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (IsEnterKeyDown())
            {
                ProgRing.IsActive = true;
                SaveConStr();
                //Flag should be true if successful connect
                try
                {
                    var tempFlag = await ConnHolder.CheckConAsync();
                    if (tempFlag)
                    {

                        SuccessBlock.Text = "Successful";
                    }
                    else
                    {

                        SuccessBlock.Text = "Failed";
                    }
                    ProgRing.IsActive = false;
                    SuccessBlock.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }
    }
}
