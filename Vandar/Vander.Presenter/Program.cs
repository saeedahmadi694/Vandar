using System.Diagnostics.SymbolStore;
using Vandar.InfraServices;
using Vandar.Repositories;

var ApiBaseUrl = "https://api.vandar.io/";
var Token = "";
var RefreshToken = "";
var Business = "unibook";
IVandarBaseService vandar = new VandarBaseService(ApiBaseUrl, Token, RefreshToken, Business);
//var xzcxc = await vandar.SettlementService.GetList();
//var sss = await vandar.AuthService.RefreshToken(new Vandar.Dtos.RefreshTokenRequest { RefreshToken = RefreshToken });
var sxx = "";