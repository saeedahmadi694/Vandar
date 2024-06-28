using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vandar.Dtos
{

    public class SettlementResponse
    {
        public int Status { get; set; }
        public SettlementData Data { get; set; }
    }

    public class SettlementData
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
}
