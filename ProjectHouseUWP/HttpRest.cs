using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Graphics.Canvas.Text;
using System.Net.Http;
using Windows.Storage;
using System.Net;
using System.Diagnostics;
using Microsoft.Toolkit.Extensions;

namespace ProjectHouseUWP
{
    class HttpRest
    {
        readonly static string pathToXMLFirst = @"File.xml";//@"C:\Users\Администратор\Desktop\XMLs\File.xml";
        readonly static string pathToXMLCheck = @"File2.xml";//@"C:\Users\Администратор\Desktop\XMLs\File2.xml";
        readonly static StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
        readonly static string amerca = "https://api.vetrf.ru/platform/services/2.0/ApplicationManagementService";
        static string smartPath = "";
        static HttpClient client;
        private static void FormXMLFile(IenumerationPaths ienumerationPaths, Model selected)
        {
            DateTime now = DateTime.Now;

            DateTime prevYear = new DateTime(2020, 01, 01);
            if (ienumerationPaths == IenumerationPaths.PostFirstTime)
            {
                smartPath = storageFolder.Path + "\\" + pathToXMLFirst;
                //Debug.WriteLine(smartPath);
                using (FileStream fstream = new FileStream($"{smartPath}", FileMode.OpenOrCreate))
                {
                    string text = "";
                    text += "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>\n";
                    text += "<SOAP-ENV:Envelope xmlns:dt=\"http://api.vetrf.ru/schema/cdm/dictionary/v2\"\n";
                    text += "xmlns:bs=\"http://api.vetrf.ru/schema/cdm/base\" xmlns:merc=\"http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2\"\n";
                    text += "xmlns:apldef=\"http://api.vetrf.ru/schema/cdm/application/ws-definitions\" xmlns:apl=\"http://api.vetrf.ru/schema/cdm/application\"\n";
                    text += "xmlns:vd=\"http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2\" xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\">\n";
                    text += "<SOAP-ENV:Header/>\n";
                    text += "<SOAP-ENV:Body>\n";
                    text += "<apldef:submitApplicationRequest>\n";
                    text += "<apldef:apiKey>" + selected.APIKey + "</apldef:apiKey>\n";
                    text += "<apl:application>\n";
                    text += "<apl:serviceId>mercury-g2b.service:2.1</apl:serviceId>\n";
                    text += "<apl:issuerId>" + selected.PlaceGuid + "</apl:issuerId>\n"; //replace to automotate process
                    text += "<apl:issueDate>" + now.ToString("yyyy-MM-dd") + "T" + now.ToString("hh:mm:ss") + "</apl:issueDate>\n";
                    text += "<apl:data>\n";
                    text += "<merc:getVetDocumentChangesListRequest>\n";
                    text += "<merc:localTransactionId>td102</merc:localTransactionId>\n";
                    text += "<merc:initiator>\n";
                    text += "<vd:login>" + selected.User + "</vd:login>\n";
                    text += "</merc:initiator>\n";
                    text += "<bs:listOptions/>\n";
                    text += "<bs:updateDateInterval>\n";
                    text += "<bs:beginDate>" + prevYear.ToString("yyyy-MM-dd") + "T00:00:00</bs:beginDate>\n";
                    text += "<bs:endDate>" + now.ToString("yyyy-MM-dd") + "T23:59:59</bs:endDate>\n";
                    text += "</bs:updateDateInterval>\n";
                    text += "<dt:enterpriseGuid>" + selected.CompanyGuid + "</dt:enterpriseGuid>\n";
                    text += "</merc:getVetDocumentChangesListRequest>\n";
                    text += "</apl:data>\n";
                    text += "</apl:application>\n";
                    text += "</apldef:submitApplicationRequest>\n";
                    text += "</SOAP-ENV:Body>\n";
                    text += "</SOAP-ENV:Envelope>\n";
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    fstream.Write(array, 0, array.Length);
                }
                    /*StorageFile sampleFile = await storageFolder.CreateFileAsync("File.xml", Windows.Storage.CreationCollisionOption.ReplaceExisting);
                    
                    //await FileIO.AppendTextAsync(sampleFile, "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>\n");
                //await FileIO.AppendTextAsync(sampleFile, "<SOAP-ENV:Envelope xmlns:dt=\"http://api.vetrf.ru/schema/cdm/dictionary/v2\"\n");
                //await FileIO.AppendTextAsync(sampleFile, "xmlns:bs=\"http://api.vetrf.ru/schema/cdm/base\" xmlns:merc=\"http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2\"\n");
                //await FileIO.AppendTextAsync(sampleFile, "xmlns:apldef=\"http://api.vetrf.ru/schema/cdm/application/ws-definitions\" xmlns:apl=\"http://api.vetrf.ru/schema/cdm/application\"\n");
                //await FileIO.AppendTextAsync(sampleFile, "xmlns:vd=\"http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2\" xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\">\n");
                //await FileIO.AppendTextAsync(sampleFile, "<SOAP-ENV:Header/>\n");
                //await FileIO.AppendTextAsync(sampleFile, "<SOAP-ENV:Body>\n");
                //await FileIO.AppendTextAsync(sampleFile, "<apldef:submitApplicationRequest>\n");
                //await FileIO.AppendTextAsync(sampleFile, "<apldef:apiKey>" + selected.APIKey + "</apldef:apiKey>\n");
                //await FileIO.AppendTextAsync(sampleFile, "<apl:application>\n");
                //await FileIO.AppendTextAsync(sampleFile, "<apl:serviceId>mercury-g2b.service:2.1</apl:serviceId>\n");
                //await FileIO.AppendTextAsync(sampleFile, "<apl:issuerId>" + selected.CompanyGuid + "</apl:issuerId>\n");
                //await FileIO.AppendTextAsync(sampleFile, "<apl:issueDate>" + now.ToString("yyyy-MM-dd") + "T" + now.ToString("hh:mm:ss") + "</apl:issueDate>\n");
                await FileIO.AppendTextAsync(sampleFile, "<apl:data>\n");
                await FileIO.AppendTextAsync(sampleFile, "<merc:getVetDocumentChangesListRequest>\n");
                await FileIO.AppendTextAsync(sampleFile, "<merc:localTransactionId>td102</merc:localTransactionId>\n");
                await FileIO.AppendTextAsync(sampleFile, "<merc:initiator>\n");
                await FileIO.AppendTextAsync(sampleFile, "<vd:login>" + selected.User + "</vd:login>\n");
                await FileIO.AppendTextAsync(sampleFile, "</merc:initiator>\n");
                await FileIO.AppendTextAsync(sampleFile, "<bs:listOptions/>\n");
                //await FileIO.AppendTextAsync(sampleFile, "</bs:listOptions>\n");
                await FileIO.AppendTextAsync(sampleFile, "<bs:updateDateInterval>\n");
                await FileIO.AppendTextAsync(sampleFile, "<bs:beginDate>" + prevYear.ToString("yyyy-MM-dd") + "T00:00:00</bs:beginDate>\n");
                await FileIO.AppendTextAsync(sampleFile, "<bs:endDate>" + now.ToString("yyyy-MM-dd") + "T23:59:59</bs:endDate>\n");
                await FileIO.AppendTextAsync(sampleFile, "</bs:updateDateInterval>\n");
                await FileIO.AppendTextAsync(sampleFile, "<dt:enterpriseGuid>" + selected.CompanyGuid + "</dt:enterpriseGuid>\n");
                

                await FileIO.AppendTextAsync(sampleFile, "</merc:getVetDocumentChangesListRequest>\n");
                await FileIO.AppendTextAsync(sampleFile, "</apl:data>\n");
                await FileIO.AppendTextAsync(sampleFile, "</apl:application>\n");
                await FileIO.AppendTextAsync(sampleFile, "</apldef:submitApplicationRequest>\n");
                await FileIO.AppendTextAsync(sampleFile, "</SOAP-ENV:Body>\n");
                await FileIO.AppendTextAsync(sampleFile, "</SOAP-ENV:Envelope>\n");
                    */

            }
            else if (ienumerationPaths == IenumerationPaths.PostToCheck)
            {
                smartPath = storageFolder.Path + "\\" + pathToXMLCheck;
                using (FileStream fstream = new FileStream($"{smartPath}", FileMode.OpenOrCreate))
                {
                    string text = "";
                    text += "<SOAP-ENV:Envelope xmlns:dt=\"http://api.vetrf.ru/schema/cdm/dictionary/v2\"\n";
                    text += "xmlns:bs=\"http://api.vetrf.ru/schema/cdm/base\" xmlns:merc=\"http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2\"\n";
                    text += "xmlns:ws=\"http://api.vetrf.ru/schema/cdm/application/ws-definitions\" xmlns:apl=\"http://api.vetrf.ru/schema/cdm/application\"\n";
                    text += "xmlns:vd=\"http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2\" xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\">\n";
                    text += "<SOAP-ENV:Header/>\n";
                    text += "<SOAP-ENV:Body>\n";
                    text += "<ws:receiveApplicationResultRequest>\n";
                    text += "<ws:apiKey>" + selected.APIKey + "</ws:apiKey>\n";
                    text += "<ws:issuerId>" + selected.PlaceGuid + "</ws:issuerId>\n"; // replace to automotate process
                    text += "<ws:applicationId>" + selected.AppId + "</ws:applicationId>\n";
                    text += "</ws:receiveApplicationResultRequest>\n";
                    text += "</SOAP-ENV:Body>\n";
                    text += "</SOAP-ENV:Envelope>\n";
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    fstream.Write(array, 0, array.Length);
                }
                /*
                    StorageFile sampleFileToCheck = await storageFolder.CreateFileAsync("File2.xml", Windows.Storage.CreationCollisionOption.ReplaceExisting);

                await FileIO.AppendTextAsync(sampleFileToCheck, "<SOAP-ENV:Envelope xmlns:dt=\"http://api.vetrf.ru/schema/cdm/dictionary/v2\"\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "xmlns:bs=\"http://api.vetrf.ru/schema/cdm/base\" xmlns:merc=\"http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2\"\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "xmlns:ws=\"http://api.vetrf.ru/schema/cdm/application/ws-definitions\" xmlns:apl=\"http://api.vetrf.ru/schema/cdm/application\"\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "xmlns:vd=\"http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2\" xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\">\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "<SOAP-ENV:Header/>\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "<SOAP-ENV:Body>\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "<ws:receiveApplicationResultRequest>\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "<ws:apiKey>" + selected.APIKey + "</ws:apiKey>\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "<ws:issuerId>" + selected.PlaceGuid + "</ws:issuerId>\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "<ws:applicationId>" + selected.AppId + "</ws:applicationId>\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "</ws:receiveApplicationResultRequest>\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "</SOAP-ENV:Body>\n");
                await FileIO.AppendTextAsync(sampleFileToCheck, "</SOAP-ENV:Envelope>\n");
                */
            }
                    
        }

        public static async Task<string> InfoPostAsync(IenumerationPaths ienumerationPaths, Model selected)
        {
            NetworkCredential cred = new NetworkCredential();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            cred.UserName = selected.APILogin;
            cred.Password = selected.APIPass;
            httpClientHandler.Credentials = cred;
            client = new HttpClient(httpClientHandler);
            
            FormXMLFile(ienumerationPaths, selected);
            using (FileStream fstream = File.OpenRead($"{smartPath}"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                
                //Debug.WriteLine(smartPath);
                //Debug.WriteLine(textFromFile);
                try
                {

                    var data = new StringContent(textFromFile);
                    var Request = new HttpRequestMessage(HttpMethod.Post, amerca);
                    Request.Content = data;
                    var Response = await client.SendAsync(Request);
                    var responseString = await Response.Content.ReadAsStringAsync();
                    return responseString;

                    //Debug.WriteLine(responseString);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                    return e.Message;
                }

            }
            
        }

    }
}
