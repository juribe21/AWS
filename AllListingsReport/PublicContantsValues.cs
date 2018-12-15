using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllListingsReport
{
    public static class PublicContantsValues
    {
        // -- SIGNATURE --  Cehck → Move to configFile ----
        public static string SignatureMethod { get { return "HmacSHA256"; } } 
        public static string SignatureVersion { get { return "2"; } }
        public static string VersionOrders { get { return "2009-01-01"; } }
        public static string AWS_Url { get { return "https://mws.amazonservices.com/"; } }
        public static string ModuleOrders { get { return "doc"; } }
        // ----------

       
        public static string AppID { get { return "3"; } }
        
        /// -- XMLPATH --
        public static string DownloadedOrderFileNameXml { get { return "downloaded_order.xml"; } }
        public static string ReportRequestListFileNameXml { get { return "downloaded_report_request_list.xml"; } }
        public static string ReportFileNameXml { get { return "downloaded_report.txt"; } }

        /// -- ACTION_ORDERS --
        /*A*/public static string OrderActionRequestReport { get { return "RequestReport"; } } // A
        /*B*/public static string OrderActionGetReportRequestList { get { return "GetReportRequestList"; } } // B
        /*C*/public static string OrderActionGetReport { get { return "GetReport"; } } // C

        public static string ReportType { get { return "_GET_MERCHANT_LISTINGS_ALL_DATA_"; } }

        // -- DB Transaction Options
        public static string Delete { get { return "DELETE"; } }
        public static string Clean { get { return "CLEAN"; } }
        public static string Insert { get { return "INSERT"; } }
        public static string DeleteProduction { get { return "DELETE_PRODUCTION"; } }

    }
}
