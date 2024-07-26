using System.Diagnostics.SymbolStore;
using Vandar.Dtos;
using Vandar.InfraServices;
using Vandar.Repositories;

var ApiBaseUrl = "https://api.vandar.io/";
var IPGApiBaseUrl = "https://ipg.vandar.io/";
var Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIyIiwianRpIjoiZjZmZmVjMWU5ZmQ1NDMxNjgyODAwNzJhYTlmMDEzYTBiYzQ1NmY5NTEwMjIwODMwMmE2M2ZhNTVjMjVjM2YyMmI2MjZkNGE4ZDQyYzJmNWMiLCJpYXQiOjE3MjE4NTEzNzUuOTkxNzUyLCJuYmYiOjE3MjE4NTEzNzUuOTkxNzU3LCJleHAiOjE3MjIyODMzNzUuOTgxODM5LCJzdWIiOiIzMDIzMSIsInNjb3BlcyI6WyIqIl19.qKybdeSxYyn5C1FQr_oxH4_3-7ps7zhj5Gj0bk7xXirQO8pfhvfF-mtxmgAhrrvbZMhJny137vK8GdqHF73Mn4abWHreNejITpB6mWe1ugOL13YZ6Bmwd4iVo0uI-7QjYMTECvczIPhGBrPdkhXpy-blG16QalqaJDUHiIiPUBX-fpv1l_o04J1U1HOaBD9btdAw7mAkxAZDMei-F8201d3cn6X_wPkKNRgXvxTNt4pZ4i6z-moCndc3fGMTYdNylLFQAfbdoai5gjpJ4JpyL0_AUNGs-FxFBVsh7pmKk-eE6Hno1L-HFKdOQTc8lnvvIR40e_Bmgl5SF2cN8Rub8OnYk-9jzN-1HOIrkdyGGl-Qe6H3IzN_MgQ7z0atfU0Upaw_ZdNWoQYgVhYuO-IzZYeH8YKs_E-rIauH2KRUZYNk7iI9ucyPVNdiX9XVKtXWisjnuBdikqiexhuGr4kvbRT8n0i1EpMx6-fqhtkQO4wv8AdooHXqlZqyzsPmwqgkyFmjFNVExRBaVITLpa9jjYaJR8kjoUfi8TXk-jAQf3auAwuxSwaWsCv5uc1J5d1_uKmTmKAW16hWd3Chj3V83h1LlpTDk3i01l05aiMyBt6Rb_R5jxHhM95LVayOyLDhOobT9mF4x3FW94SaAxYoYW7_BPBAvNbBrZeUnMVrKv4";
var RefreshToken = "";
var Business = "unibook";
IVandarBaseService vandar = new VandarBaseService(IPGApiBaseUrl);
//var xzcxc = await vandar.SettlementService.GetList();
//var sss = await vandar.AuthService.RefreshToken(new Vandar.Dtos.RefreshTokenRequest { RefreshToken = RefreshToken });
var sxx = "";

var apiKey = "ea7a6b313cb11cb173a562c0bcd95d6839b1850c"; // Replace with your actual API key
var vandarPaymentGateway = vandar.IPGService;

try
{
    // Step 1: Send transaction details and receive a payment token
    var sendRequestDto = new SendTransactionRequestDto
    {
        ApiKey = apiKey,
        Amount = 10000,
        CallbackUrl = "https://unibook.shop/verify",
        MobileNumber = "09123456789",
        Description = "Test Transaction"
    };

    var sendResponseDto = await vandarPaymentGateway.SendTransactionDetailsAsync(sendRequestDto);
    Console.WriteLine("Payment Token: " + sendResponseDto.Token);

    // Step 2: Redirect user to the payment page
    var sss = vandarPaymentGateway.RedirectToPaymentPage(sendResponseDto.Token);

    // Step 3: (Optional) Get transaction info before verification
    //var infoRequestDto = new TransactionInfoRequestDto
    //{
    //    ApiKey = apiKey,
    //    Token = sendResponseDto.Token
    //};

    //var transactionInfoDto = await vandarPaymentGateway.GetTransactionInfoAsync(infoRequestDto);
    //Console.WriteLine("Transaction Info: " + transactionInfoDto);

    // Step 4: Verify the transaction
    var verifyRequestDto = new VerifyTransactionRequestDto
    {
        ApiKey = apiKey,
        Token = sendResponseDto.Token
    };

    var verifyResponseDto = await vandarPaymentGateway.VerifyTransactionAsync(verifyRequestDto);
    Console.WriteLine("Verification Result: " + verifyResponseDto);
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}