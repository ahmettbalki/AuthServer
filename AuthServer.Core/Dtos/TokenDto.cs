namespace AuthServer.Core.Dtos;

public class TokenDto
{
    public string AccessToken { get; set; }
    public DateTime AccessExpiration { get; set; }
    public string ResfreshToken { get; set; }
    public DateTime ResfreshTokenExpiration { get; set; }
}
