using EventCalendarApp.Models.DTOs;

namespace EventCalendarApp.Interface
{
    public interface ITokenService
    {
        string GetToken(UserDTO user);
    }
}
