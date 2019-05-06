using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Common
{
    public interface IPrincipalUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
        int? UserId { get; set; }
    }
}
