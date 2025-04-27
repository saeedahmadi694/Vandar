using System.Threading.Tasks;
using VandarSharp.Core.Models;

namespace VandarSharp.Core.InfraServices
{

    public interface IIPGService
    {
        Task<VerifyTransactionResponseDto> VerifyTransactionAsync(VerifyTransactionRequestDto requestDto);
        Task<TransactionInfoResponseDto> GetTransactionInfoAsync(TransactionInfoRequestDto requestDto);
        Task<SendTransactionResponseDto> SendTransactionDetailsAsync(SendTransactionRequestDto requestDto);
        string RedirectToPaymentPage(string token);
    }
}