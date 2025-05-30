﻿using VandarSharp.Core.InfraServices;

namespace VandarSharp.Core.Repositories
{
    public class VandarBaseService : IVandarBaseService
    {
        private readonly string _apiBaseUrl;
        private readonly string _ipgApiBaseUrl;
        private readonly string _ipgToken;
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
        public VandarBaseService(string ipgApiBaseUrl, string ipgToken)
        {
            _ipgApiBaseUrl = ipgApiBaseUrl;
            _ipgToken = ipgToken;
        }
        public VandarBaseService(string apiBaseUrl, string token, string reFereshToken, string business, string ipgApiBaseUrl, string ipgToken)
        {
            _apiBaseUrl = apiBaseUrl;
            _token = token;
            _business = business;
            _ipgApiBaseUrl = ipgApiBaseUrl;
            _reFereshToken = reFereshToken;
            _ipgToken = ipgToken;
        }


        private IAuthService _authService;
        public IAuthService AuthService
        {
            get
            {
                _authService ??= new AuthService(_apiBaseUrl, _token, _reFereshToken);
                return _authService;
            }
        }
        private ISettlementService _settlementService;
        public ISettlementService SettlementService
        {
            get
            {
                _settlementService ??= new SettlementService(_apiBaseUrl, _token, _business);
                return _settlementService;
            }
        }
        private IPayByVandarService _payByVandarService;
        public IPayByVandarService PayByVandarService
        {
            get
            {
                _payByVandarService ??= new PayByVandarService(_apiBaseUrl, _token, _business);
                return _payByVandarService;
            }
        }
        private IIPGService _iPGService;
        public IIPGService IPGService
        {
            get
            {
                _iPGService ??= new IPGService(_ipgApiBaseUrl, _ipgToken);
                return _iPGService;
            }
        }
        private IInvoiceService _invoiceService;
        public IInvoiceService InvoiceService
        {
            get
            {
                _invoiceService ??= new InvoiceService(_apiBaseUrl, _token, _business);
                return _invoiceService;
            }
        }
        private IBusinessService _businessService;
        public IBusinessService BusinessService
        {
            get
            {
                _businessService ??= new BusinessService(_apiBaseUrl, _token, _business);
                return _businessService;
            }
        }
    }
}