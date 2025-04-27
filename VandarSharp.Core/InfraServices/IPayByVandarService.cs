using System.Threading.Tasks;
using VandarSharp.Core.Models;

namespace VandarSharp.Core.InfraServices
{

    // PayByVandar
    public interface IPayByVandarService 
    {
        Task<BaseResponse<PayByVandarSendResponse>> Send(PayByVandarSendRequest request);
        Task<BaseResponse<PayByVandarVerifyResponse>> Verify(PayByVandarVerifyRequest request);
        Task<BaseResponse<PayByVandarInquiryResponse>> Inquiry(string checkoutId);
    }

    public class PayByVandarSendRequest
    {
        public string CheckoutNumber { get; set; }
        public string Mobile { get; set; }
        public string Amount { get; set; }
        public string CallbackUrl { get; set; }
        public string Description { get; set; }
    }

    public class PayByVandarSendResponse
    {
        // Define properties based on the actual response
    }

    public class PayByVandarVerifyRequest
    {
        public string CheckoutId { get; set; }
    }

    public class PayByVandarVerifyResponse
    {
        // Define properties based on the actual response
    }

    public class PayByVandarInquiryResponse
    {
        // Define properties based on the actual response
    }
}
