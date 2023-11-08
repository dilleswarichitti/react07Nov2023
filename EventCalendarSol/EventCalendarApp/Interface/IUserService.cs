using EventCalendarApp.Models.DTOs;

namespace EventCalendarApp.Interface
{
    public interface IUserService
    {
        UserDTO Login(UserDTO userDTO);
        UserDTO Register(UserDTO userDTO);
    }
}
