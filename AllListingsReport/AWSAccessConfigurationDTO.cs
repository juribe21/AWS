using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllListingsReport
{
    public class AWSAccessConfigurationDTO
    {
        public string AWS_ACCESS_KEY_ID { get; set; }
        public string AWS_SECRET_ACCESS_KEY { get; set; }
        public string MERCHANT_ID { get; set; }
        public string MARKETPLACE_ID { get; set; }
        
        public string SIGNATUREMETHOD { get; set; }
        public string SIGNATUREVERSION { get; set; }
        public string VERSION_ORDERS { get; set; }
        
        public string AMWS_URL { get; set; }
        public string MODULE_ORDERS { get; set; }
        public string ACTION_ORDERS { get; set; }
        public string REPORT_TYPE { get; set; }
    }
}
