using Vandar.Dtos;

namespace Vandar.InfraServices;



public interface IBusinessService
{
    Task<BusinessInfoResponse> GetInfo();
    Task<BusinessUsersResponse> GetUsers();
}

public class BusinessInfoResponse
{
    // Define properties based on the actual response
}

public class BusinessUsersResponse
{
    // Define properties based on the actual response
}
