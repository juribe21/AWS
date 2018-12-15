using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AllListingsReport.PublicContantsValues;

namespace AllListingsReport
{
    public class AWSConfiguration : IConnection
    {
        public AWSAccessConfigurationDTO _awsAccess { get; set; }

        public AWSAccessConfigurationDTO GetAccessConfiguration()
        {
            _awsAccess = new AWSAccessConfigurationDTO();

            _awsAccess.AWS_ACCESS_KEY_ID = ConfigurationManager.AppSettings["ACCESS_KEY"].ToString(); ;
            _awsAccess.AWS_SECRET_ACCESS_KEY = ConfigurationManager.AppSettings["AWS_ASECRET_KEY"].ToString();
            _awsAccess.MERCHANT_ID = ConfigurationManager.AppSettings["MERCHANT_ID"];
            _awsAccess.MARKETPLACE_ID = ConfigurationManager.AppSettings["MARKETPLACE_ID"];

            _awsAccess.SIGNATUREMETHOD = SignatureMethod;
            _awsAccess.SIGNATUREVERSION = SignatureVersion;
            _awsAccess.VERSION_ORDERS = VersionOrders;
            _awsAccess.AMWS_URL = AWS_Url;
            _awsAccess.MODULE_ORDERS = ModuleOrders;
            _awsAccess.ACTION_ORDERS = null;
            /* asign directly on into method call
            _awsAccess.ACTION_ORDERS = OrderActionRequestReport;
            _awsAccess.ACTION_ORDERS = OrderActionGetReportRequestList;
            _awsAccess.ACTION_ORDERS = OrderActionGetReport;
            */
            _awsAccess.REPORT_TYPE = ReportType;

            return _awsAccess;
        }
    }
}
