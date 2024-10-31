using AuthServer.Core.Dtos;
using SharedLibrary.Dtos;
namespace AuthServer.Core.Services;
public interface IAuthenticationService
{
    Task<Response<TokenDto>> CreateToken(LoginDto loginDto);
    Task<Response<TokenDto>> CreateTokenByRefreshToken(string refreshToken);
    Task<Response<NoDataDto>> RevokeResfreshToken(string refreshToken);
    Task<Response<ClientTokenDto>> CreateTokenByClient(ClientTokenDto clientTokenDto);
}