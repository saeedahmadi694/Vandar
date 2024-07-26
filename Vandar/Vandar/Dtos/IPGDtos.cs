using Newtonsoft.Json;

namespace Vandar.Dtos;

public class SendTransactionResponseDto
{
    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("token")]
    public string Token { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }
}

public class TransactionInfoResponseDto
{
    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("wage")]
    public string Wage { get; set; }

    [JsonProperty("shaparakWage")]
    public string ShaparakWage { get; set; }

    [JsonProperty("transId")]
    public long TransId { get; set; }

    [JsonProperty("refnumber")]
    public string RefNumber { get; set; }

    [JsonProperty("trackingCode")]
    public string TrackingCode { get; set; }

    [JsonProperty("factorNumber")]
    public string FactorNumber { get; set; }

    [JsonProperty("mobile")]
    public string Mobile { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("cardNumber")]
    public string CardNumber { get; set; }

    [JsonProperty("CID")]
    public string CID { get; set; }

    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("paymentDate")]
    public DateTime PaymentDate { get; set; }

    [JsonProperty("code")]
    public int Code { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }
}

public class VerifyTransactionResponseDto
{
    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("amount")]
    public string Amount { get; set; }

    [JsonProperty("realAmount")]
    public int RealAmount { get; set; }

    [JsonProperty("wage")]
    public string Wage { get; set; }

    [JsonProperty("shaparakWage")]
    public string ShaparakWage { get; set; }

    [JsonProperty("transId")]
    public long TransId { get; set; }

    [JsonProperty("factorNumber")]
    public string FactorNumber { get; set; }

    [JsonProperty("mobile")]
    public string Mobile { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("cardNumber")]
    public string CardNumber { get; set; }

    [JsonProperty("paymentDate")]
    public DateTime PaymentDate { get; set; }

    [JsonProperty("cid")]
    public string CID { get; set; }

    [JsonProperty("message")]
    public string Message { get; set; }
}

public class SendTransactionRequestDto
{
    [JsonProperty("api_key")]
    public string ApiKey { get; set; } // Required

    [JsonProperty("amount")]
    public int Amount { get; set; } // Required

    [JsonProperty("callback_url")]
    public string CallbackUrl { get; set; } // Required

    [JsonProperty("mobile_number")]
    public string MobileNumber { get; set; } // Optional

    [JsonProperty("factorNumber")]
    public string FactorNumber { get; set; } // Optional

    [JsonProperty("description")]
    public string Description { get; set; } // Optional

    [JsonProperty("national_code")]
    public string NationalCode { get; set; } // Optional

    [JsonProperty("valid_card_number")]
    public string[] ValidCardNumber { get; set; } // Optional

    [JsonProperty("comment")]
    public string Comment { get; set; } // Optional

    [JsonProperty("port")]
    public string Port { get; set; } // Optional
}

public class TransactionInfoRequestDto
{
    [JsonProperty("api_key")]
    public string ApiKey { get; set; } // Required

    [JsonProperty("token")]
    public string Token { get; set; } // Required
}

public class VerifyTransactionRequestDto
{
    [JsonProperty("api_key")]
    public string ApiKey { get; set; } // Required

    [JsonProperty("token")]
    public string Token { get; set; } // Required
}