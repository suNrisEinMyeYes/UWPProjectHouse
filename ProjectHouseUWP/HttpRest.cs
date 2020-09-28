using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Graphics.Canvas.Text;
using System.Net.Http;

namespace ProjectHouseUWP
{
    class HttpRest
    {
        readonly static string pathToXMLFirst = @"C:\Users\Администратор\Desktop\XMLs\File.xml";
        readonly static string pathToXMLCheck = @"C:\Users\Администратор\Desktop\XMLs\File2.xml";
        readonly static string amerca = "https://api.vetrf.ru/platform/services/2.0/ApplicationManagementService";
        static string smartPath = "";
        static readonly HttpClient client = new HttpClient();
        private static void FormXMLFile(IenumerationPaths ienumerationPaths)
        {

            if (ienumerationPaths == IenumerationPaths.PostFirstTime)
            {
                smartPath = pathToXMLFirst;
                using (StreamWriter txs = File.CreateText(pathToXMLFirst))
                {
                    txs.WriteLine("<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>");
                    txs.WriteLine("<SOAP-ENV:Envelope xmlns:dt=\"http://api.vetrf.ru/schema/cdm/dictionary/v2\"");
                    txs.WriteLine("xmlns:bs=\"http://api.vetrf.ru/schema/cdm/base\" xmlns:merc=\"http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2\"");
                    txs.WriteLine("xmlns:apldef=\"http://api.vetrf.ru/schema/cdm/application/ws-definitions\" xmlns:apl=\"http://api.vetrf.ru/schema/cdm/application\"");
                    txs.WriteLine("xmlns:vd=\"http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2\" xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\">");
                    txs.WriteLine("<SOAP-ENV:Header/>");
                    txs.WriteLine("<SOAP-ENV:Body>");
                    txs.WriteLine("<apldef:submitApplicationRequest>");
                    txs.WriteLine("<apldef:apiKey>" + apks + "</apldef:apiKey>");
                    txs.WriteLine("<apl:application>");
                    txs.WriteLine("<apl:serviceId>mercury-g2b.service:2.1</apl:serviceId>");
                    txs.WriteLine("<apl:issuerId>" + gds + "</apl:issuerId>");
                    txs.WriteLine("<apl:issueDate>" + format("DY3,DO(%Y-%M-%D)", date(Today())) + "T" + format("TO(%H:%M:%S)", time()) + "</apl:issueDate>");
                    txs.WriteLine("<apl:data>");
                    txs.WriteLine("<merc:getVetDocumentListRequest>");
                    txs.WriteLine("<merc:localTransactionId>td102</merc:localTransactionId>");
                    txs.WriteLine("<merc:initiator>");
                    txs.WriteLine("<vd:login>" + ints + "</vd:login>");
                    txs.WriteLine("</merc:initiator>");
                    txs.WriteLine("<bs:listOptions>");
                    txs.WriteLine("</bs:listOptions>");
                    txs.WriteLine("<vd:issueDateInterval>");
                    txs.WriteLine("<bs:beginDate>" + format("DY3,DO(%Y-%M-%D)", date(Dat1)) + "T00:00:00</bs:beginDate>");
                    txs.WriteLine("<bs:endDate>" + format("DY3,DO(%Y-%M-%D)", date(Dat2)) + "T23:59:59</bs:endDate>");
                    txs.WriteLine("</vd:issueDateInterval>");
                    txs.WriteLine("<dt:enterpriseGuid>" + gds + "</dt:enterpriseGuid>");
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
                    }

                    txs.WriteLine("</merc:getVetDocumentListRequest>");
                    txs.WriteLine("</apl:data>");
                    txs.WriteLine("</apl:application>");
                    txs.WriteLine("</apldef:submitApplicationRequest>");
                    txs.WriteLine("</SOAP-ENV:Body>");
                    txs.WriteLine("</SOAP-ENV:Envelope>");

                }
            }
            else if (ienumerationPaths == IenumerationPaths.PostToCheck)
            {
                smartPath = pathToXMLCheck;
                using (StreamWriter txs = File.CreateText(pathToXMLCheck))
                {
                    txs.WriteLine("<SOAP-ENV:Envelope xmlns:dt=\"http://api.vetrf.ru/schema/cdm/dictionary/v2\"");
                    txs.WriteLine("xmlns:bs=\"http://api.vetrf.ru/schema/cdm/base\" xmlns:merc=\"http://api.vetrf.ru/schema/cdm/mercury/g2b/applications/v2\"");
                    txs.WriteLine("xmlns:ws=\"http://api.vetrf.ru/schema/cdm/application/ws-definitions\" xmlns:apl=\"http://api.vetrf.ru/schema/cdm/application\"");
                    txs.WriteLine("xmlns:vd=\"http://api.vetrf.ru/schema/cdm/mercury/vet-document/v2\" xmlns:SOAP-ENV=\"http://schemas.xmlsoap.org/soap/envelope/\">");
                    txs.WriteLine("<SOAP-ENV:Header/>");
                    txs.WriteLine("<SOAP-ENV:Body>");
                    txs.WriteLine("<ws:receiveApplicationResultRequest>");
                    txs.WriteLine("<ws:apiKey>" + apks + "</ws:apiKey>");
                    txs.WriteLine("<ws:issuerId>" + gdps + "</ws:issuerId>");
                    txs.WriteLine("<ws:applicationId>" + apds + "</ws:applicationId>");
                    txs.WriteLine("</ws:receiveApplicationResultRequest>");
                    txs.WriteLine("</SOAP-ENV:Body>");
                    txs.WriteLine("</SOAP-ENV:Envelope>");

                }
            }

        }

        public static async Task InfoPostAsync(IenumerationPaths ienumerationPaths)
        {
            FormXMLFile(ienumerationPaths);
            try
            {
                var data = new StringContent(smartPath, Encoding.UTF8);
                var Response =  await client.PostAsync(amerca, data);
                Console.WriteLine(Response);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

    }
}
