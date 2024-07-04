using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vandar.Dtos
{
    public class SettlementStoreRequest
    {
        public int Amount { get; set; }
        public string Iban { get; set; }
        public string TrackId { get; set; }
        public string PaymentNumber { get; set; }
        public string NotifyUrl { get; set; }
        public bool IsInstant { get; set; }
    }


    public class SettlementStoreResponse
    {
        public Settlement[] Settlements { get; set; }
    }

    public class Settlement
    {
        public string Id { get; set; }
        public string IbanId { get; set; }
        public long TransactionId { get; set; }
        public int Amount { get; set; }
        public int AmountToman { get; set; }
        public int WageToman { get; set; }
        public int? PaymentNumber { get; set; }
        public string Status { get; set; }
        public string Wallet { get; set; }
        public string SettlementDate { get; set; }
        public string SettlementTime { get; set; }
        public string SettlementDateJalali { get; set; }
        public string SettlementDoneTimePrediction { get; set; }
        public string Description { get; set; }
        public string ReceiptUrl { get; set; }
    }
    public class AuthenticationResponse
    {
        public string TokenType { get; set; }
        public int ExpiresIn { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }




    public class SettlementListResponse
    {
        public int wallet { get; set; }
        public int blocked_amount { get; set; }
        public int deductible_amount { get; set; }
        public string currency { get; set; }
        public string id { get; set; }
        public int iban_id { get; set; }
        public object gateway_transaction_id { get; set; }
        public int amount { get; set; }
        public object payment_number { get; set; }
        public string status { get; set; }
        public string settlement_date { get; set; }
        public string description { get; set; }
    }




    public class SettlementShowResponse
    {
        public string id { get; set; }
        public int iban_id { get; set; }
        public long gateway_transaction_id { get; set; }
        public int amount { get; set; }
        public string payment_number { get; set; }
        public string status { get; set; }
        public int wallet { get; set; }
        public string settlement_date { get; set; }
        public string settlement_done_time_prediction { get; set; }
        public object description { get; set; }
    }


}
