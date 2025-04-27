using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VandarSharp.Core.Models
{

    public class A2A
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class Accountant
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class AddressDetail
    {
        public string provinces { get; set; }
        public int provinces_id { get; set; }
        public string provinces_code { get; set; }
        public string city { get; set; }
        public int city_id { get; set; }
        public object local { get; set; }
        public object local_id { get; set; }
        public string address { get; set; }
    }

    public class Api
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class CashIn
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public string time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class CashInContract
    {
        public string iban { get; set; }
        public string status { get; set; }
        public long expiration { get; set; }
    }

    public class Customer
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class BusinessInfoResponse
    {
        public int id { get; set; }
        public string uuid { get; set; }
        public int active { get; set; }
        public string business_name { get; set; }
        public string business_name_fa { get; set; }
        public object legal_business_name { get; set; }
        public object business_owner_is_business_legal_owner { get; set; }
        public object national_id { get; set; }
        public string business_type { get; set; }
        public string phone_number { get; set; }
        public string tax_code { get; set; }
        public TaxCodeDetail tax_code_detail { get; set; }
        public EnamadDetail enamad_detail { get; set; }
        public string postal_code { get; set; }
        public PostalCodeDetail postal_code_detail { get; set; }
        public NationalCodeDetail national_code_detail { get; set; }
        public AddressDetail address_detail { get; set; }
        public object city_id { get; set; }
        public string mcc_code { get; set; }
        public object address { get; set; }
        public int wallet { get; set; }
        public int deductible_amount { get; set; }
        public int payment_facilitator_wallet { get; set; }
        public int blocked_amount { get; set; }
        public string avatar { get; set; }
        public bool automatic_settlement_tip { get; set; }
        public string settlement_schedule { get; set; }
        public string default_iban { get; set; }
        public object ayandeh_default_iban { get; set; }
        public StatusBox statusBox { get; set; }
        public int status { get; set; }
        public string business_status { get; set; }
        public int today_transactions { get; set; }
        public int today_settlements { get; set; }
        public string role_name { get; set; }
        public string role { get; set; }
        public List<string> permissions { get; set; }
        public bool has_shaparak_terminal { get; set; }
        public Tools tools { get; set; }
        public IpgStatus ipg_status { get; set; }
        public string accept_business_time_prediction { get; set; }
        public bool has_rejection { get; set; }
        public Rejects rejects { get; set; }
        public List<CashInContract> cash_in_contracts { get; set; }
        public object cash_in_code { get; set; }
        public Owner owner { get; set; }
        public double high_value_fee { get; set; }
        public bool need_shaparak_iban { get; set; }
        public int pic_suspicious_check { get; set; }
    }

    public class EnamadDetail
    {
        public object enamad_status { get; set; }
        public object code { get; set; }
    }

    public class Ipg
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public string time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class IpgStatus
    {
        public Url url { get; set; }
        public WebsiteName website_name { get; set; }
    }

    public class Kerdar
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class Log
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class Miando
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class MPG
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public string time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class NationalCodeDetail
    {
        public string national_code_status { get; set; }
        public object message { get; set; }
    }

    public class Owner
    {
        public string birthdate { get; set; }
        public string birth_certificate_number { get; set; }
        public string national_code { get; set; }
    }

    public class P2p
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class PBV
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class Pos
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class PostalCodeDetail
    {
        public string postal_code_status { get; set; }
        public object message { get; set; }
    }

    public class Refund
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class Rejects
    {
        public object company_name_fa { get; set; }
        public object national_code { get; set; }
        public object default_iban { get; set; }
        public object legal_name { get; set; }
        public object business_license_image { get; set; }
        public object introduction_letter { get; set; }
        public object national_image { get; set; }
        public object address { get; set; }
        public object phone_number { get; set; }
        public object postal_code { get; set; }
        public object ipg_url { get; set; }
        public object register_number { get; set; }
        public object register_date { get; set; }
        public object birth_certificate_number { get; set; }
    }

    public class RequestMoney
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }


    public class SettlementBatch
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class StatusBox
    {
        public bool payment_required { get; set; }
        public string national_card_photo { get; set; }
        public string official_Newspaper { get; set; }
        public string introduction_letter { get; set; }
    }

    public class Subscription
    {
        public bool is_enabled { get; set; }
        public bool is_created { get; set; }
        public string status { get; set; }
        public object time { get; set; }
        public bool viewable { get; set; }
        public string name_fa { get; set; }
        public string name_en { get; set; }
    }

    public class TaxCodeDetail
    {
        public string tax_code_status { get; set; }
        public object message { get; set; }
    }

    public class Tools
    {
        public Ipg ipg { get; set; }
        public Subscription subscription { get; set; }
        public RequestMoney requestMoney { get; set; }
        public Api api { get; set; }
        public Customer customer { get; set; }
        public Log log { get; set; }
        public P2p p2p { get; set; }
        public Refund refund { get; set; }
        public SettlementBatch settlement_batch { get; set; }

        [JsonProperty("cash-in")]
        public CashIn cashin { get; set; }
        public Kerdar kerdar { get; set; }
        public Pos pos { get; set; }
        public Accountant accountant { get; set; }
        public PBV PBV { get; set; }
        public A2A A2A { get; set; }
        public Miando miando { get; set; }
        public MPG MPG { get; set; }
    }

    public class Url
    {
        public object value { get; set; }
        public object time { get; set; }
        public object status { get; set; }
    }

    public class WebsiteName
    {
        public object value { get; set; }
        public object time { get; set; }
        public object status { get; set; }
    }


}
