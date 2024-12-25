using Newtonsoft.Json;
using System.Collections.Generic;

namespace Vandar.Dtos
{
    public class SettlementStoreRequest
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }
        [JsonProperty("iban")]
        public string? Iban { get; set; }
        [JsonProperty("track_id")]
        public string? TrackId { get; set; }
        [JsonProperty("payment_number")]
        public string? PaymentNumber { get; set; }
        [JsonProperty("notify_url")]
        public string? NotifyUrl { get; set; }
        [JsonProperty("type")]
        public string? Type { get; set; }
        [JsonProperty("description")]
        public string? Description { get; set; }
        [JsonProperty("is_instant")]
        public bool IsInstant { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class SettlementStoreResponse
    {
        public List<Settlement>? settlement { get; set; }
    }



    public class Settlement
    {
        public string? id { get; set; }
        public string? iban_id { get; set; }
        public long transaction_id { get; set; }
        public int amount { get; set; }
        public int amount_toman { get; set; }
        public int wage_toman { get; set; }
        public object? payment_number { get; set; }
        public string? status { get; set; }
        public string? wallet { get; set; }
        public string? description { get; set; }
        public string? settlement_date { get; set; }
        public string? settlement_time { get; set; }
        public string? settlement_date_jalali { get; set; }
        public string? settlement_done_time_prediction { get; set; }
        public bool is_instant { get; set; }
        public Prediction? prediction { get; set; }
        public string? receipt_url { get; set; }
        public string? type { get; set; }
    }


    public class Prediction
    {
        public string? date { get; set; }
        public string? time { get; set; }
        public string? extra { get; set; }
    }

    public class SettlementListResponse
    {
        public int wallet { get; set; }
        public int blocked_amount { get; set; }
        public int deductible_amount { get; set; }
        public string? currency { get; set; }
        public string? id { get; set; }
        public int iban_id { get; set; }
        public object? gateway_transaction_id { get; set; }
        public int amount { get; set; }
        public object? payment_number { get; set; }
        public string? status { get; set; }
        public string? settlement_date { get; set; }
        public string? description { get; set; }
    }



    public class SettlementShowResponse
    {
        public string? id { get; set; }
        public int iban_id { get; set; }
        public long gateway_transaction_id { get; set; }
        public int amount { get; set; }
        public string? payment_number { get; set; }
        public string? status { get; set; }
        public int wallet { get; set; }
        public string? settlement_date { get; set; }
        public string? settlement_done_time_prediction { get; set; }
        public object? description { get; set; }
    }


}
