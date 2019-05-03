using MyRecipe.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Models.Entities
{
    public partial class User : TrackedEntity
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
