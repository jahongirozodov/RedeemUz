using RedeemUz.Service.DTOs.Users;
using RedeemUz.Service.Interfaces;

namespace RedeemUz.Service.services
{
    public class UserService : IUserService
    {
        public ValueTask<bool> DestroyAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserResultDto> LoginAsync(UserLoginDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserResultDto> ModifyAsync(UserUpdateDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserResultDto> RegisterAsync(UserCreationDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> RemoveAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<UserResultDto>> RetrieveAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserResultDto> RetrieveByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserResultDto> RetrieveByPhoneAsync(string phone)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdatePasswordAsync(long UserId, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public ValueTask<UserResultDto> UpgradeRoleAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
