using Microsoft.AspNetCore.Identity;

namespace ToDoList.Data.Identity
{
    public class User : IdentityUser
    {
        public string UserName { get; set; }
    }
}
