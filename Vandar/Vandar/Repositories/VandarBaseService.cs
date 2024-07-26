namespace Vandar.Repositories;
using Vandar.InfraServices;

public class VandarBaseService : IVandarBaseService
{
    private readonly string _apiBaseUrl;
    private readonly string _ipgApiBaseUrl;
    private readonly string _token;
    private readonly string _reFereshToken;
    private readonly string _business;

    public VandarBaseService(string apiBaseUrl, string token, string reFereshToken, string business)
    {
        _apiBaseUrl = apiBaseUrl;
        _token = token;
        _business = business;
        _reFereshToken = reFereshToken;
    }
    public VandarBaseService(string apiBaseUrl, string token, string reFereshToken, string business, string ipgApiBaseUrl)
    {
        _apiBaseUrl = apiBaseUrl;
        _token = token;
        _business = business;
        _ipgApiBaseUrl = ipgApiBaseUrl;
        _reFereshToken = reFereshToken;
    }
    public VandarBaseService(string ipgApiBaseUrl)
    {
        _ipgApiBaseUrl = ipgApiBaseUrl;
    }

    private IAuthService _authService;
    public IAuthService AuthService
    {
        get
        {
            if (_authService == null)
                _authService = new AuthService(_apiBaseUrl, _token, _reFereshToken);
            return _authService;
        }
    }
    private ISettlementService _settlementService;
    public ISettlementService SettlementService
    {
        get
        {
            if (_settlementService == null)
                _settlementService = new SettlementService(_apiBaseUrl, _token, _business);
            return _settlementService;
        }
    }
    private IPayByVandarService _payByVandarService;
    public IPayByVandarService PayByVandarService
    {
        get
        {
            if (_payByVandarService == null)
                _payByVandarService = new PayByVandarService(_apiBaseUrl, _token, _business);
            return _payByVandarService;
        }
    }
    private IIPGService _iPGService;
    public IIPGService IPGService
    {
        get
        {
            if (_iPGService == null)
                _iPGService = new IPGService(_ipgApiBaseUrl);
            return _iPGService;
        }
    }
    private IInvoiceService _invoiceService;
    public IInvoiceService InvoiceService
    {
        get
        {
            if (_invoiceService == null)
                _invoiceService = new InvoiceService(_apiBaseUrl, _token, _business);
            return _invoiceService;
        }
    }
    private IBusinessService _businessService;
    public IBusinessService BusinessService
    {
        get
        {
            if (_businessService == null)
                _businessService = new BusinessService(_apiBaseUrl, _token, _business);
            return _businessService;
        }
    }
}