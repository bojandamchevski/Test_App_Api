using Dtos.UserDtos;

namespace Services.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterUserDto registerUserDto);
        string Login(LoginUserDto loginDto);
        void Delete(int id);
        void Update(UpdateUserDto userDto, int id);
    }
}
