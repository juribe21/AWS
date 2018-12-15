using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static AllListingsReport.PublicContantsValues;

namespace AllListingsReport
{
    public class AWSOrders : IAWSOrders
    {
        public ReportProcess reportProcess { get; set; }
        public DBOperations dBOperations { get; set; }
        private AWSAccessConfigurationDTO _awsAccessConfiguration;
        public string XmlPath { get; set; }
        public string message = string.Empty;

        private IConnection _iConnection;
        private IReportProcess _iReportProcess;
        private IDBOperations _iDbOperations;

        string tempStr = string.Empty;
        string unsignedStr = string.Empty;
        string Timestamp = string.Empty;
        string signature = string.Empty;
        string awsUrl = string.Empty;
        KeyedHashAlgorithm algorithm = null;
        WebRequest request = null;
        HttpWebResponse response = null;


        public AWSOrders(IConnection iconnection, IReportProcess ireportProcess, IDBOperations idBOperations)
        {
            _iConnection = iconnection;
            _iReportProcess = ireportProcess;
            _iDbOperations = idBOperations;
        }

        private void GetAwsConfigurations() /// AWSvOrders()
        {
            _awsAccessConfiguration = _iConnection.GetAccessConfiguration();
            XmlPath = _iDbOperations.GetXmlPath(DownloadedOrderFileNameXml);
        }

        public void AWSvOrders()
        {  
        }

        public string AMWSOrdersLoad(string ReportRequestIdList)
        {
            try
            {
                unsignedStr = "POST" + "\n" + _awsAccessConfiguration.AMWS_URL + "\n" + "/\n";
                Timestamp = GetTimeStamp();
                string tempCredentials = GetAWSCredentials();
                unsignedStr += tempCredentials;
                tempCredentials += "&Signature=" + CreateTokenSignature();

                awsUrl = AWS_Url + tempCredentials;
                _iDbOperations.Log(awsUrl);
                /* cDisplay.Display(sUrl); */

                /* 
                  Begin URL Request
                  Create Reponse
                  The purpose xml read is get information about API and log it. and concatenate the response
                 */

            }
            catch (Exception error)
            {
                message = error.Message;
            }

            return message;
        }

        public string AMWSOrdersLoad(string Folio, string ReportId = null)
        {
            try
            {

            }
            catch (Exception error)
            {
                message = error.Message;
            }

            return message;
        }

        public string AWSOrdersLoad()
        {
            throw new NotImplementedException();
        }

        public string AWSOrdersLoad(string Folio)
        {
            throw new NotImplementedException();
        }

        public string Download(string stream)
        {
            throw new NotImplementedException();
        }

       

        public string Sign(string data, string key, KeyedHashAlgorithm keyedHashAlgorithm)
        {
            throw new NotImplementedException();
        }

        
        private string GetTimeStamp()
        {
            Timestamp = DateTime.UtcNow.ToString("s") + "Z";
            Timestamp = System.Web.HttpUtility.UrlEncode(Timestamp);
            Timestamp = Timestamp.ToUpper();
            Timestamp = Timestamp.Replace("~", "%7E");

            return Timestamp;
        }

        private string GetAWSCredentials()
        {
            tempStr = "AWSAccessKeyId=" + _awsAccessConfiguration.AWS_ACCESS_KEY_ID +
                      "&Action=" + _awsAccessConfiguration.ACTION_ORDERS +
                      "&Merchant=" + _awsAccessConfiguration.MERCHANT_ID +
                      "&ReportType=" + _awsAccessConfiguration.REPORT_TYPE +
                      "&SignatureMethod=" + _awsAccessConfiguration.SIGNATUREMETHOD +
                      "&SignatureVersion=" + _awsAccessConfiguration.SIGNATUREVERSION +
                      "&Timestamp=" + Timestamp +
                      "&Version=" + _awsAccessConfiguration.VERSION_ORDERS;

            return tempStr;
        }

        private string CreateTokenSignature()
        {
            algorithm = new HMACSHA1();
            algorithm = KeyedHashAlgorithm.Create(SignatureMethod);
            signature = Sign(unsignedStr, _awsAccessConfiguration.AWS_ACCESS_KEY_ID, algorithm);
            signature = System.Web.HttpUtility.UrlEncode(signature);
            signature = FhtmlEncodeReplace(signature);

            return signature;
        }

        public string FhtmlEncodeReplace(string signature)
        {
            signature = signature.Replace("%2a", "%2A");
            signature = signature.Replace("%2b", "%2B");
            signature = signature.Replace("%2c", "%2C");
            signature = signature.Replace("%2d", "%2D");
            signature = signature.Replace("%2e", "%2E");
            signature = signature.Replace("%2f", "%2F");

            signature = signature.Replace("%3a", "%3A");
            signature = signature.Replace("%3b", "%3B");
            signature = signature.Replace("%3c", "%3C");
            signature = signature.Replace("%3d", "%3D");
            signature = signature.Replace("%3e", "%3E");
            signature = signature.Replace("%3f", "%3F");

            signature = signature.Replace("%4a", "%4A");
            signature = signature.Replace("%4b", "%4B");
            signature = signature.Replace("%4c", "%4C");
            signature = signature.Replace("%4d", "%4D");
            signature = signature.Replace("%4e", "%4E");
            signature = signature.Replace("%4f", "%4F");

            signature = signature.Replace("%5a", "%5A");
            signature = signature.Replace("%5b", "%5B");
            signature = signature.Replace("%5c", "%5C");
            signature = signature.Replace("%5d", "%5D");
            signature = signature.Replace("%5e", "%5E");
            signature = signature.Replace("%5f", "%5F");

            signature = signature.Replace("%6a", "%6A");
            signature = signature.Replace("%6b", "%6B");
            signature = signature.Replace("%6c", "%6C");
            signature = signature.Replace("%6d", "%6D");
            signature = signature.Replace("%6e", "%6E");
            signature = signature.Replace("%6f", "%6F");

            signature = signature.Replace("%7a", "%7A");
            signature = signature.Replace("%7b", "%7B");
            signature = signature.Replace("%7c", "%7C");
            signature = signature.Replace("%7d", "%7D");
            signature = signature.Replace("%7e", "%7E");
            signature = signature.Replace("%7f", "%7F");

            signature = signature.Replace("%8a", "%8A");
            signature = signature.Replace("%8b", "%8B");
            signature = signature.Replace("%8c", "%8C");
            signature = signature.Replace("%8d", "%8D");
            signature = signature.Replace("%8e", "%8E");
            signature = signature.Replace("%8f", "%8F");

            signature = signature.Replace("%9a", "%9A");
            signature = signature.Replace("%9b", "%9B");
            signature = signature.Replace("%9c", "%9C");
            signature = signature.Replace("%9d", "%9D");
            signature = signature.Replace("%9e", "%9E");
            signature = signature.Replace("%9f", "%9F");

            return signature;
        }
    }
}
