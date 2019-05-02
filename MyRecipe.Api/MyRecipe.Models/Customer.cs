namespace MyRecipe.Models
{
    public partial class Customer : TrackedEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string customerEmail;
        public string Email
        {
            get { return customerEmail; }
            set { customerEmail = value?.ToLower(); }
        }
    }
}
