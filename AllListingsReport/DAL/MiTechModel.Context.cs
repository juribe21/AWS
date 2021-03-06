﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AllListingsReport.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MiTechEntities : DbContext
    {
        public MiTechEntities()
            : base("name=MiTechEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<Nullable<long>> sp_AmazonAPI_Apps(string pOption, string pParam00, string pParam01, string pParam02, string pParam03)
        {
            var pOptionParameter = pOption != null ?
                new ObjectParameter("pOption", pOption) :
                new ObjectParameter("pOption", typeof(string));
    
            var pParam00Parameter = pParam00 != null ?
                new ObjectParameter("pParam00", pParam00) :
                new ObjectParameter("pParam00", typeof(string));
    
            var pParam01Parameter = pParam01 != null ?
                new ObjectParameter("pParam01", pParam01) :
                new ObjectParameter("pParam01", typeof(string));
    
            var pParam02Parameter = pParam02 != null ?
                new ObjectParameter("pParam02", pParam02) :
                new ObjectParameter("pParam02", typeof(string));
    
            var pParam03Parameter = pParam03 != null ?
                new ObjectParameter("pParam03", pParam03) :
                new ObjectParameter("pParam03", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("sp_AmazonAPI_Apps", pOptionParameter, pParam00Parameter, pParam01Parameter, pParam02Parameter, pParam03Parameter);
        }
    
        public virtual ObjectResult<string> sp_GetAllListingsReport(string pOption, string item_name, string item_description, string listing_id, string seller_sku, string price, string quantity, string open_date, string image_url, string item_is_marketplace, string product_id_type, string zshop_shipping_fee, string item_note, string item_condition, string zshop_category1, string zshop_browse_path, string zshop_storefront_feature, string asin1, string asin2, string asin3, string will_ship_internationally, string expedited_shipping, string zshop_boldface, string product_id, string bid_for_featured_placement, string add_delete, string pending_quantity, string fulfillment_channel, string merchant_shipping_group, string status)
        {
            var pOptionParameter = pOption != null ?
                new ObjectParameter("pOption", pOption) :
                new ObjectParameter("pOption", typeof(string));
    
            var item_nameParameter = item_name != null ?
                new ObjectParameter("item_name", item_name) :
                new ObjectParameter("item_name", typeof(string));
    
            var item_descriptionParameter = item_description != null ?
                new ObjectParameter("item_description", item_description) :
                new ObjectParameter("item_description", typeof(string));
    
            var listing_idParameter = listing_id != null ?
                new ObjectParameter("listing_id", listing_id) :
                new ObjectParameter("listing_id", typeof(string));
    
            var seller_skuParameter = seller_sku != null ?
                new ObjectParameter("seller_sku", seller_sku) :
                new ObjectParameter("seller_sku", typeof(string));
    
            var priceParameter = price != null ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(string));
    
            var quantityParameter = quantity != null ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(string));
    
            var open_dateParameter = open_date != null ?
                new ObjectParameter("open_date", open_date) :
                new ObjectParameter("open_date", typeof(string));
    
            var image_urlParameter = image_url != null ?
                new ObjectParameter("image_url", image_url) :
                new ObjectParameter("image_url", typeof(string));
    
            var item_is_marketplaceParameter = item_is_marketplace != null ?
                new ObjectParameter("item_is_marketplace", item_is_marketplace) :
                new ObjectParameter("item_is_marketplace", typeof(string));
    
            var product_id_typeParameter = product_id_type != null ?
                new ObjectParameter("product_id_type", product_id_type) :
                new ObjectParameter("product_id_type", typeof(string));
    
            var zshop_shipping_feeParameter = zshop_shipping_fee != null ?
                new ObjectParameter("zshop_shipping_fee", zshop_shipping_fee) :
                new ObjectParameter("zshop_shipping_fee", typeof(string));
    
            var item_noteParameter = item_note != null ?
                new ObjectParameter("item_note", item_note) :
                new ObjectParameter("item_note", typeof(string));
    
            var item_conditionParameter = item_condition != null ?
                new ObjectParameter("item_condition", item_condition) :
                new ObjectParameter("item_condition", typeof(string));
    
            var zshop_category1Parameter = zshop_category1 != null ?
                new ObjectParameter("zshop_category1", zshop_category1) :
                new ObjectParameter("zshop_category1", typeof(string));
    
            var zshop_browse_pathParameter = zshop_browse_path != null ?
                new ObjectParameter("zshop_browse_path", zshop_browse_path) :
                new ObjectParameter("zshop_browse_path", typeof(string));
    
            var zshop_storefront_featureParameter = zshop_storefront_feature != null ?
                new ObjectParameter("zshop_storefront_feature", zshop_storefront_feature) :
                new ObjectParameter("zshop_storefront_feature", typeof(string));
    
            var asin1Parameter = asin1 != null ?
                new ObjectParameter("asin1", asin1) :
                new ObjectParameter("asin1", typeof(string));
    
            var asin2Parameter = asin2 != null ?
                new ObjectParameter("asin2", asin2) :
                new ObjectParameter("asin2", typeof(string));
    
            var asin3Parameter = asin3 != null ?
                new ObjectParameter("asin3", asin3) :
                new ObjectParameter("asin3", typeof(string));
    
            var will_ship_internationallyParameter = will_ship_internationally != null ?
                new ObjectParameter("will_ship_internationally", will_ship_internationally) :
                new ObjectParameter("will_ship_internationally", typeof(string));
    
            var expedited_shippingParameter = expedited_shipping != null ?
                new ObjectParameter("expedited_shipping", expedited_shipping) :
                new ObjectParameter("expedited_shipping", typeof(string));
    
            var zshop_boldfaceParameter = zshop_boldface != null ?
                new ObjectParameter("zshop_boldface", zshop_boldface) :
                new ObjectParameter("zshop_boldface", typeof(string));
    
            var product_idParameter = product_id != null ?
                new ObjectParameter("product_id", product_id) :
                new ObjectParameter("product_id", typeof(string));
    
            var bid_for_featured_placementParameter = bid_for_featured_placement != null ?
                new ObjectParameter("bid_for_featured_placement", bid_for_featured_placement) :
                new ObjectParameter("bid_for_featured_placement", typeof(string));
    
            var add_deleteParameter = add_delete != null ?
                new ObjectParameter("add_delete", add_delete) :
                new ObjectParameter("add_delete", typeof(string));
    
            var pending_quantityParameter = pending_quantity != null ?
                new ObjectParameter("pending_quantity", pending_quantity) :
                new ObjectParameter("pending_quantity", typeof(string));
    
            var fulfillment_channelParameter = fulfillment_channel != null ?
                new ObjectParameter("fulfillment_channel", fulfillment_channel) :
                new ObjectParameter("fulfillment_channel", typeof(string));
    
            var merchant_shipping_groupParameter = merchant_shipping_group != null ?
                new ObjectParameter("merchant_shipping_group", merchant_shipping_group) :
                new ObjectParameter("merchant_shipping_group", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_GetAllListingsReport", pOptionParameter, item_nameParameter, item_descriptionParameter, listing_idParameter, seller_skuParameter, priceParameter, quantityParameter, open_dateParameter, image_urlParameter, item_is_marketplaceParameter, product_id_typeParameter, zshop_shipping_feeParameter, item_noteParameter, item_conditionParameter, zshop_category1Parameter, zshop_browse_pathParameter, zshop_storefront_featureParameter, asin1Parameter, asin2Parameter, asin3Parameter, will_ship_internationallyParameter, expedited_shippingParameter, zshop_boldfaceParameter, product_idParameter, bid_for_featured_placementParameter, add_deleteParameter, pending_quantityParameter, fulfillment_channelParameter, merchant_shipping_groupParameter, statusParameter);
        }
    }
}
