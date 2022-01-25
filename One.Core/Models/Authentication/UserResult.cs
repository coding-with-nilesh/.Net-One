using One.Core.Validation;

namespace One.Core.Models.Authentication
{
    public class UserResult<TUser> : RequestResult<TUser>
    {
        public UserResult(TUser user) : base(user)
        {
           
        }

        public UserResult(ValidationResult validationResult):base(validationResult)
        {
          
        }

        public UserResult(ValidationResultForJson validationResult):base(validationResult)
        {
          
        }

        public TUser User { get { return Result; } }
    }
}
