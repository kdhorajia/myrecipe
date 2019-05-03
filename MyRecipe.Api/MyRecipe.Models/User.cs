using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Models
{
    public partial class User : TrackedEntity
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
