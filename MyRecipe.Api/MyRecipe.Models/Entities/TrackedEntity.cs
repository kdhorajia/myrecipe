using MyRecipe.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Models.Entities
{
    public class TrackedEntity : Entity
    {
        public bool Deleted { get; set; }

    }
}
