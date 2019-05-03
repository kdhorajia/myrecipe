using System.Collections.Generic;

namespace MyRecipe.Models
{
    public partial class Customer : TrackedEntity
    {
        public Customer()
        {
            Recipe = new HashSet<Recipe>();
            ShoppingList = new HashSet<ShoppingList>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string customerEmail;
        public string Email
        {
            get { return customerEmail; }
            set { customerEmail = value?.ToLower(); }
        }

        public virtual ICollection<Recipe> Recipe { get; set; }
        public virtual ICollection<ShoppingList> ShoppingList { get; set; }

        public virtual User User { get; set; }
    }
}
