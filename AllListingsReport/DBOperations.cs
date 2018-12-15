using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using static AllListingsReport.PublicContantsValues;

namespace AllListingsReport
{
    public class DBOperations : IDBOperations
    {
        public SqlCommand cmd { get; set; }
        public string connectionString { get; set; }
        public string appfolder { get; set; }
        public string path { get; set; }

        public string MerchantID { get; set; }
        public string MarketPlaceID { get; set; }
        public string SellerName { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string Message { get; set; } = string.Empty;

        int rowsAffected = 0;
        string date = string.Empty;
        string datetime = string.Empty;

        public DBOperations()
        {
        }

        /// cConfig.Log methods here
        public string Log(string Text)
        {
            try
            {
                appfolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = appfolder.Replace("file:\\", string.Empty) + "\\Log";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                date = DateTime.Now.ToString("yyyy-MM-dd");
                datetime = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss]");
                Text = datetime + Text;

                /// name of log file
                path += "\\log_" + date.Replace("-", string.Empty) + ".txt";
                File.AppendAllLines(path, new[] { Text });
            }
            catch (Exception error)
            {
                Message = error.Message;
            }

            return Message;
        }

        public string GetXmlPath(string option)
        {
            appfolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = appfolder.Replace("file:\\", string.Empty) + "\\Log";
            // add Validation
            switch (option)
            {
                case "downloaded_order.xml":                    
                    path += DownloadedOrderFileNameXml;
                    break;
                case "downloaded_report_request_list.xml":                   
                    path += DownloadedOrderFileNameXml;
                    break;
                case "downloaded_report.xml":                    
                    path += DownloadedOrderFileNameXml;
                    break;
            }
           
            return path;
        }

        /// <summary>
        /// option param can be 'DELETE', 'CLEAN' or 'DELETE_PRODUCTION'
        /// Method applies for DeeleteProductionData
        /// </summary>
        public string AllListingsReportOperations(string option)
        {
            try
            {
                cmd = new SqlCommand();
                connectionString = ConfigurationManager.ConnectionStrings["MiTechWebStation"].ConnectionString;
                using (var connection = new SqlConnection(connectionString))
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "sp_GetAllListingsReport";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pOption", option);
                    cmd.CommandTimeout = 0;
                    connection.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                    connection.Close();
                }                
                Message = rowsAffected.ToString(); // check it
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            return Message;
        }

        public string AllListingsReportInsertData(AllListingsReportDTO alReport, string option)
        {
            try
            {
                cmd = new SqlCommand();
                connectionString = ConfigurationManager.ConnectionStrings["MiTechWebStation"].ConnectionString;
                using (var connection = new SqlConnection(connectionString))
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "sp_GetAllListingsReport";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pOption", option);
                    cmd.Parameters.AddWithValue("@item_name", alReport.item_name);
                    cmd.Parameters.AddWithValue("@item_description", alReport.item_description);
                    cmd.Parameters.AddWithValue("@listing_id", alReport.listing_id);
                    cmd.Parameters.AddWithValue("@seller_sku", alReport.seller_sku);
                    cmd.Parameters.AddWithValue("@price", alReport.price);
                    cmd.Parameters.AddWithValue("@quantity", alReport.quantity);
                    cmd.Parameters.AddWithValue("@open_date", alReport.open_date);
                    cmd.Parameters.AddWithValue("@image_url", alReport.image_url);
                    cmd.Parameters.AddWithValue("@item_is_marketplace", alReport.item_is_marketplace);
                    cmd.Parameters.AddWithValue("@product_id_type", alReport.product_id_type);
                    cmd.Parameters.AddWithValue("@zshop_shipping_fee", alReport.zshop_shipping_fee);
                    cmd.Parameters.AddWithValue("@item_note", alReport.item_note);
                    cmd.Parameters.AddWithValue("@item_condition", alReport.item_condition);
                    cmd.Parameters.AddWithValue("@zshop_category1", alReport.zshop_category1);
                    cmd.Parameters.AddWithValue("@zshop_browse_path", alReport.zshop_browse_path);
                    cmd.Parameters.AddWithValue("@zshop_storefront_feature", alReport.zshop_storefront_feature);
                    cmd.Parameters.AddWithValue("@asin1", alReport.asin1);
                    cmd.Parameters.AddWithValue("@asin2", alReport.asin2);
                    cmd.Parameters.AddWithValue("@asin3", alReport.asin3);
                    cmd.Parameters.AddWithValue("@will_ship_internationally", alReport.will_ship_internationally);
                    cmd.Parameters.AddWithValue("@expedited_shipping", alReport.expedited_shipping);
                    cmd.Parameters.AddWithValue("@zshop_boldface", alReport.zshop_boldface);
                    cmd.Parameters.AddWithValue("@product_id", alReport.product_id);
                    cmd.Parameters.AddWithValue("@bid_for_featured_placement", alReport.bid_for_featured_placement);
                    cmd.Parameters.AddWithValue("@add_delete", alReport.add_delete);
                    cmd.Parameters.AddWithValue("@pending_quantity", alReport.pending_quantity);
                    cmd.Parameters.AddWithValue("@fulfillment_channel", alReport.fulfillment_channel);
                    cmd.Parameters.AddWithValue("@merchant_shipping_group", alReport.merchant_shipping_group);
                    cmd.Parameters.AddWithValue("@status", alReport.status);

                    cmd.CommandTimeout = 0;
                    connection.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                    connection.Close();
                }
                Message = rowsAffected.ToString(); // check it
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            return Message;
        }
    }
}
