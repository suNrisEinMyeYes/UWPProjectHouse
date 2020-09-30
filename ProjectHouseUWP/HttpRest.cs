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
        private static async void FormXMLFile(IenumerationPaths ienumerationPaths, Model selected)
        {
            DateTime now = DateTime.Now;
            DateTime prevYear = new DateTime(2020, 01, 01);
            if (ienumerationPaths == IenumerationPaths.PostFirstTime)
            {
                smartPath = pathToXMLFirst;
                StorageFile sampleFile = await storageFolder.CreateFileAsync("File.xml", Windows.Storage.CreationCollisionOption.ReplaceExisting);

                await FileIO.AppendTextAsync(sampleFile, "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>\n");
                await FileIO.AppendTextAsync(sampleFile, "<SOAP-ENV:Envelope xmlns:dt=\"http://api.vetrf.ru/schema/cdm/dictionary/v2\"\n");
                await FileIO.AppendTextAsync(sampleFile, "xmlns:bs=\"http://api.vetrf.ru/schema/cdm/base\" xmlns:merc=\"http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2\"\n");
                await FileIO.AppendTextAsync(sampleFile, "xmlns:apldef=\"http://api.vetrf.ru/schema/cdm/application/ws-definitions\" xmlns:apl=\"http://api.vetrf.ru/schema/cdm/application\"\n");
                await FileIO.AppendTextAsync(sampleFile, "xmlns:vd=\"http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2\" xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\">\n");
                await FileIO.AppendTextAsync(sampleFile, "<SOAP-ENV:Header/>\n");
                await FileIO.AppendTextAsync(sampleFile, "<SOAP-ENV:Body>\n");
                await FileIO.AppendTextAsync(sampleFile, "<apldef:submitApplicationRequest>\n");
                await FileIO.AppendTextAsync(sampleFile, "<apldef:apiKey>" + selected.APIKey + "</apldef:apiKey>\n");
                await FileIO.AppendTextAsync(sampleFile, "<apl:application>\n");
                await FileIO.AppendTextAsync(sampleFile, "<apl:serviceId>mercury-g2b.service:2.1</apl:serviceId>\n");
                await FileIO.AppendTextAsync(sampleFile, "<apl:issuerId>" + selected.CompanyGuid + "</apl:issuerId>\n");
                await FileIO.AppendTextAsync(sampleFile, "<apl:issueDate>" + now.ToString("yyyy.mm.dd") + "T" + now.ToString("hh:mm:ss") + "</apl:issueDate>\n");
                await FileIO.AppendTextAsync(sampleFile, "<apl:data>\n");
                await FileIO.AppendTextAsync(sampleFile, "<merc:getVetDocumentListRequest>\n");
                await FileIO.AppendTextAsync(sampleFile, "<merc:localTransactionId>td102</merc:localTransactionId>\n");
                await FileIO.AppendTextAsync(sampleFile, "<merc:initiator>\n");
                await FileIO.AppendTextAsync(sampleFile, "<vd:login>" + selected.User + "</vd:login>\n");
                await FileIO.AppendTextAsync(sampleFile, "</merc:initiator>\n");
                await FileIO.AppendTextAsync(sampleFile, "<bs:listOptions>\n");
                await FileIO.AppendTextAsync(sampleFile, "</bs:listOptions>\n");
                await FileIO.AppendTextAsync(sampleFile, "<vd:issueDateInterval>\n");
                await FileIO.AppendTextAsync(sampleFile, "<bs:beginDate>" + prevYear.ToString("yyyy.mm.dd") + "T00:00:00</bs:beginDate>\n");
                await FileIO.AppendTextAsync(sampleFile, "<bs:endDate>" + now.ToString("yyyy.mm.dd") + "T23:59:59</bs:endDate>\n");
                await FileIO.AppendTextAsync(sampleFile, "</vd:issueDateInterval>\n");
                await FileIO.AppendTextAsync(sampleFile, "<dt:enterpriseGuid>" + selected.CompanyGuid + "</dt:enterpriseGuid>\n");
                await FileIO.AppendTextAsync(sampleFile, "<vd:vetDocumentType>INCOMING</vd:vetDocumentType>\n");
                await FileIO.AppendTextAsync(sampleFile, "<vd:vetDocumentStatus>UTILIZED</vd:vetDocumentStatus>\n");

                /*
                switch (FD_tp)
                {
                    case "Входящие":
                        txs.WriteLine("<vd:vetDocumentType>INCOMING</vd:vetDocumentType>");
                        break;
                    case "Исходящие":
                        txs.WriteLine("<vd:vetDocumentType>OUTGOING</vd:vetDocumentType>");
                        break;
                    case "Транспортные":
                        txs.WriteLine("<vd:vetDocumentType>TRANSPORT</vd:vetDocumentType>");
                        break;

                    case "Производственные":
                        txs.WriteLine("<vd:vetDocumentType>PRODUCTIVE</vd:vetDocumentType>");
                        break;

                    case "Возвратные":
                        txs.WriteLine("<vd:vetDocumentType>RETURNABLE</vd:vetDocumentType>");
                        break;

                    default:
                        break;
                }


                switch (FD_st)
                {
                    case "Погашен":
                        txs.WriteLine("<vd:vetDocumentStatus>UTILIZED</vd:vetDocumentStatus>");
                        break;

                    case "Подтвержден":
                        txs.WriteLine("<vd:vetDocumentStatus>CONFIRMED</vd:vetDocumentStatus>");
                        break;

                    case "Аннулирован":
                        txs.WriteLine("<vd:vetDocumentStatus>WITHDRAWN</vd:vetDocumentStatus>");
                        break;
                    default:
                        break;
                }*/


                await FileIO.AppendTextAsync(sampleFile, "</merc:getVetDocumentListRequest>\n");
                await FileIO.AppendTextAsync(sampleFile, "</apl:data>\n");
                await FileIO.AppendTextAsync(sampleFile, "</apl:application>\n");
                await FileIO.AppendTextAsync(sampleFile, "</apldef:submitApplicationRequest>\n");
                await FileIO.AppendTextAsync(sampleFile, "</SOAP-ENV:Body>\n");
                await FileIO.AppendTextAsync(sampleFile, "</SOAP-ENV:Envelope>\n");


            }
            else if (ienumerationPaths == IenumerationPaths.PostToCheck)
            {
                smartPath = pathToXMLCheck;
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
                

            }
                    
        }

        public static async Task InfoPostAsync(IenumerationPaths ienumerationPaths, Model selected)
        {
            NetworkCredential cred = new NetworkCredential();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            cred.UserName = selected.APILogin;
            cred.Password = selected.APIPass;
            Debug.WriteLine(selected.APILogin);
            Debug.WriteLine(selected.APIPass);
            httpClientHandler.Credentials = cred;
            client = new HttpClient(httpClientHandler);
            
            FormXMLFile(ienumerationPaths, selected);
            try
            {
                var data = new StringContent(smartPath, Encoding.UTF8);
                var Response =  await client.PostAsync(amerca, data);
                Debug.WriteLine(Response.StatusCode);
                Debug.WriteLine(Response.ReasonPhrase);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

    }
}
