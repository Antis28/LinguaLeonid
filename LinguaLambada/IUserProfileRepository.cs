using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada
{
   public interface IUserProfileRepository
    {
       // IUserProfile GetUserProfile(int userId);
        

        void SaveUserProfile(UserProfile newUserProfile);

        IUserProfile[] GetAllUserProfiles();
    }
}
