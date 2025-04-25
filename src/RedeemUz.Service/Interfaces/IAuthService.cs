namespace Taxify.Service.Interfaces;

public interface IAuthService
{
    ValueTask<string> GenerateTokenForUserAsync(string phone, string originalPassword);
    ValueTask<string> GenerateTokenForManagerAsync(string phone, string originalPassword);

}