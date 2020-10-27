using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ProjectHouseUWP
{
    class CommandsToWorkWithDB
    {
        public delegate void MethodContainer();
        public static event MethodContainer xmlFinish;
        public static async Task<ObservableCollection<Model>> GetProductsAsync()
        {
            var connectionString = ConnHolder.GetConnStr();
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
        public static async Task<class1.Envelope> GetXML(Model selectedOne, ObservableCollection<Model> Info)
        {

            var response = await HttpRest.InfoPostAsync(IenumerationPaths.PostFirstTime, selectedOne);
            var filledModel = XmlParser.Desirialize(response);
            var xml = new class1.Envelope();
            //string text = "No Data";

            if (filledModel.Body.submitApplicationResponse != null)
            {
                if (filledModel.Body.submitApplicationResponse.application.status == "ACCEPTED")
                {
                    foreach (var elem in Info)
                    {
                        if (elem == selectedOne)
                        {
                            elem.AppId = filledModel.Body.submitApplicationResponse.application.applicationId;
                            var Query = $"Update Merc_xs set AppID=\'{elem.AppId}\' where CodM= {elem.CodeFil} and CodB= {elem.CodePred}";
                            await ConnHolder.NonQueryAsyncConnect(Query);
                            Debug.WriteLine("Updated");
                        }
                    }
                    // = filledModel.Body.submitApplicationResponse.application.applicationId;
                    xml = XmlParser.DesirializeBig(await HttpRest.InfoPostAsync(IenumerationPaths.PostToCheck, selectedOne));
                    Debug.WriteLine(xml.Body.ReceiveApplicationResultResponse.Application.Status);
                    while (xml.Body.ReceiveApplicationResultResponse.Application.Status == "IN_PROCESS")
                    {
                        xml = XmlParser.DesirializeBig(await HttpRest.InfoPostAsync(IenumerationPaths.PostToCheck, selectedOne));
                        System.Threading.Thread.Sleep(2000);
                        //Debug.WriteLine(xml.Body.ReceiveApplicationResultResponse.Application.Status);
                    }
                    //Debug.WriteLine(xml.Body.ReceiveApplicationResultResponse.Application.Status);
                    //XmlParser.Serialize(xml);
                    //xmlFinish();
                    //text = File.ReadAllText(Windows.Storage.ApplicationData.Current.LocalFolder.Path + "\\" + "Out.xml");
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
            return xml;
        }
    }
}
