using Healthcare.Identity.Service.Dtos;
using Healthcare.Identity.Service.Entities;


namespace Healthcare.Identity.Service
{
    public static class Extensions
    {
        public static UserDto AsDto(this ApplicationUser user)
        {
            return new UserDto(
                user.Id, 
                user.UserName, 
                user.Email, 
                user.Gil, 
                user.CreatedOn);
        }
    }
}