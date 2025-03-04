using api.DTOs.Account;
using api.Models;

namespace api.Mappers
{
    public static class UserMappers
    {
        public static UserDto ToDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email
            };
        }
    }
}
