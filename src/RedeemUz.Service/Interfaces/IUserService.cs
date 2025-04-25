using RedeemUz.Service.DTOs.Users;
using Taxify.Service.DTOs.Attachments;

namespace RedeemUz.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserResultDto> RegisterAsync(UserCreationDto dto);
        ValueTask<UserResultDto> LoginAsync(UserLoginDto dto);
        ValueTask<UserResultDto> ModifyAsync(UserUpdateDto dto);
        ValueTask<bool> RemoveAsync(long id);
        ValueTask<bool> DestroyAsync(long id);
        ValueTask<IEnumerable<UserResultDto>> RetrieveAllAsync();
        ValueTask<UserResultDto> RetrieveByIdAsync(long id);
        ValueTask<UserResultDto> RetrieveByPhoneAsync(string phone);
        ValueTask<bool> UpdatePasswordAsync(long UserId, string oldPassword, string newPassword);
        ValueTask<UserResultDto> UpgradeRoleAsync(long id);
    }
}
