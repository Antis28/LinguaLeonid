﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada
{
    class RegistrationService : IRegistrationService
    {
        private readonly IUserProfileRepository _userProfileRepository;
        public RegistrationService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public int RegisterUser(string name)
        {
            var newUserId = GetNewUserId();
            var newUserProfile = new UserProfile(newUserId, name);
            _userProfileRepository.SaveUserProfile(newUserProfile);
            return newUserId;
        }

        private int GetNewUserId()
        {
            var userProfiles = _userProfileRepository.GetAllUserProfiles();
            var maxUserId = 1;
            foreach (var userProfile in userProfiles)
            {
                if (userProfile.Id > maxUserId)
                {
                    maxUserId = userProfile.Id;
                }
            }

            return maxUserId + 1;
        }
    }
}
