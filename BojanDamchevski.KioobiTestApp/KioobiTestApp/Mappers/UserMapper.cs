using Domain.Models;
using Dtos.UserDtos;

namespace Mappers
{
    public static class UserMapper
    {
        public static User ToUser(this UpdateUserDto updateUserDto)
        {
            return new User()
            {
                FirstName = updateUserDto.FirstName,
                LastName = updateUserDto.LastName,
                Email = updateUserDto.Email,
                Password = updateUserDto.Password
            };
        }
    }
}
