using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AllListingsReport
{
    public interface IAWSOrders
    {
        ReportProcess reportProcess { get; set; }
        DBOperations dBOperations { get; set; }
        string XmlPath { get; set; }

        /*
        string AWS_ACCESS_KEY_ID { get; set; }
        string AWS_SECRET_ACCESS_K { get; set; }
        string MERCHANT_ID { get; set; }
        string MARKETPLACE_ID { get; set; }

        String SIGNATUREMETHOD { get; set; }
        string SIGNATUREVERSION { get; set; }
        string VERSION_ORDERS { get; set; }

        string AMWS_URL { get; set; }
        string MODULE_ORDERS  { get; set; }
        string ACTION_ORDERS  { get; set; }
        string REPORT_TYPE { get; set; }
        */

        /// <summary>
        /// 
        /// </summary>
        void AWSvOrders();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string AWSOrdersLoad();

        /// <summary>
        /// TO DO: compare functionality between AMWSOrdersLoad methods -- cAMWSOrdersa
        /// </summary>        
        string AWSOrdersLoad(string Folio);

        /// <summary>
        /// TO DO: compare functionality between AMWSOrdersLoad methods and call -- cAMWSOrdersB
        /// </summary>
        string AMWSOrdersLoad(string ReportRequestIdList);

        /// <summary>
        /// TO DO: move to diferent Interface -- cAMWSOrdersC
        /// </summary>
        string AMWSOrdersLoad(string Folio, string ReportId = null);

        /// <summary>
        /// 
        /// </summary>
        string Download(string stream);

        /// <summary>
        /// 
        /// </summary>
        string Sign(string data, string key, KeyedHashAlgorithm keyedHashAlgorithm);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="signature"></param>
        /// <returns></returns>
        string FhtmlEncodeReplace(string signature);
    }
}
