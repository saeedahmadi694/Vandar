using Vandar.Dtos;
namespace Vandar.InfraServices
{
    public interface IVandarBaseService
    {
        IAuthService AuthService { get; }
        IBusinessService BusinessService { get; }
        IInvoiceService InvoiceService { get; }
        IIPGService IPGService { get; }
        IPayByVandarService PayByVandarService { get; }
        ISettlementService SettlementService { get; }
    }
}
