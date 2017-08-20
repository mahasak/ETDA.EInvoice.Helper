using System;
using System.Collections.Generic;
using System.Text;

namespace ETDA.Invoice.Api.Interface
{
    interface IInvoiceXmlDocument
    {
        string invoiceId { get; set; }
        string invoiceName { get; set; }
        string invoiceTypecode { get; set; }
        string invoiceIssue_date { get; set; }
        string invoicePurpose { get; set; }
        string invoicePurposeCode { get; set; }
        string invoiceCreate_date { get; set; }
        string sellerName { get; set; }
        string sellerTaxid { get; set; }
        string sellerWebsite { get; set; }
        string sellerEmail { get; set; }
        string sellerZipcode { get; set; }
        string sellerAddress1 { get; set; }
        string sellerAddress2 { get; set; }
        string sellerCityname { get; set; }
        string sellerCitySubName { get; set; }
        string sellerCountry { get; set; }
        string sellerCountrySubID { get; set; }
        string sellercontactPersonPhoneno { get; set; }
        string sellerBuildingName { get; set; }
        string buyerName { get; set; }
        string buyerTaxid { get; set; }
        string buyerWebsite { get; set; }
        string buyereMail { get; set; }
        string buyerZipcode { get; set; }
        string buyerAddress1 { get; set; }
        string buyerAddress2 { get; set; }
        string buyerCityname { get; set; }
        string buyerCitySubName { get; set; }
        string buyerCountry { get; set; }
        string buyerCountrySubID { get; set; }
        string buyerContactPerson { get; set; }
        string buyercontactPersonPhoneno { get; set; }
        string buyerBuildingName { get; set; }
        string currency { get; set; }
        string invoiceTaxcode { get; set; }
        string invoiceTaxrate { get; set; }
        string invoiceBasisamount { get; set; }
        string invoiceChargeindicator { get; set; }
        string invoiceServiceindicator { get; set; }
        string invoiceDiscount { get; set; }
        string invoiceService { get; set; }
        string invoiceLinetotal { get; set; }
        string invoiceTaxtotal { get; set; }
        string invoiceGrandtotal { get; set; }
        string invoiceOriginal { get; set; }
        string invoiceDifference { get; set; }
        string remark { get; set; }
        string itemCode { get; set; }
        string itemCodeInter { get; set; }
        string reason { get; set; }
        string reasonCode { get; set; }
        string invoiceCalculatedAmount { get; set; }
        string invoiceTaxBasisTotalAmount { get; set; }
    }
}
