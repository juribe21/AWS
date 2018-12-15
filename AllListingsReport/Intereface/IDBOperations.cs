using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AllListingsReport
{
    public interface IDBOperations
    {
        /* ***
        string DBSERVER { get; set; }
        string DBNAME { get; set; }
        string DBUSERID { get; set; }
        string DBPASSWORD { get; set; }
        **** */

        SqlCommand cmd { get; set; }
        string connectionString { get; set; }
        string appfolder { get; set; }
        string path { get; set; }

        string MerchantID { get; set; }
        string MarketPlaceID { get; set; }
        string SellerName { get; set; }
        string AccessKey { get; set; }
        string SecretKey { get; set; }
        string Message { get; set; }

        string Log(string sText);
        string AllListingsReportOperations(string option);
        string AllListingsReportInsertData(AllListingsReportDTO allListingsReport, string option);
        string GetXmlPath(string option);

        //string CleanData();
        //string DeleteProductionData(string option);
    }
}
