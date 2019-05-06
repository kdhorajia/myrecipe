using System;
using System.Security.Claims;

namespace MyRecipe.Common
{
    public class PrincipalUser : IPrincipalUser
    {
        public const string CLAIM_USER_ID = "UserName";
        public const string CLAIM_USER_FIRST_NAME = ClaimTypes.GivenName;
        public const string CLAIM_USER_LAST_NAME = ClaimTypes.Surname;

        private readonly ClaimsPrincipal _principal;
        public PrincipalUser()
        {
            _principal = ClaimsPrincipal.Current;
            SetPropertiesFromClaims();
        }

        private void SetPropertiesFromClaims()
        {
            if (_principal != null)
            {
                Claim firstNameClaim = _principal.FindFirst(CLAIM_USER_FIRST_NAME);
                FirstName = firstNameClaim != null ? firstNameClaim.Value : string.Empty;
                Claim lastNameClaim = _principal.FindFirst(CLAIM_USER_LAST_NAME);
                LastName = lastNameClaim != null ? lastNameClaim.Value : string.Empty;
                Claim userNameClaim = _principal.FindFirst(CLAIM_USER_ID);
                UserName = userNameClaim != null ? userNameClaim.Value : string.Empty;
                Claim userIdClaim = _principal.FindFirst(CLAIM_USER_ID);
                UserId = userIdClaim != null ? Convert.ToInt32(userIdClaim.Value) : default;
            }

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public int? UserId { get; set; }
    }
}
