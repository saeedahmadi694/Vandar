using Vandar.Dtos;

namespace Vandar.InfraServices;


public interface IIPGService
{
    Task<VerifyTransactionResponseDto> VerifyTransactionAsync(VerifyTransactionRequestDto requestDto);
    Task<TransactionInfoResponseDto> GetTransactionInfoAsync(TransactionInfoRequestDto requestDto);
    Task<SendTransactionResponseDto> SendTransactionDetailsAsync(SendTransactionRequestDto requestDto);
    string RedirectToPaymentPage(string token);
}