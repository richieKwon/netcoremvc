using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NetCore.Data.DataModels;
using NetCore.Data.ViewModels;
using NetCore.Services.Interfaces;

namespace NetCore.Services.SVCS
{
    public class UserService : IUser
    {
        #region Private methods

        private IEnumerable<User> GetUserInfos()
        {
            return new List<User>()
            {
                new User()
                {
                    UserId = "Richie",
                    UserName = "YeraLee",
                    UserEmail = "yera@gmail.com",
                    Password = "1234"
                }
            };
        }

        private bool CheckTheUserInfo(string userId, string password)
        {
            return GetUserInfos().Where(u=>u.UserId.Equals(userId) && u.Password.Equals(password)).Any();
        }

        #endregion

        public bool MatchTheUserInfo(LoginInfo loginInfo)
        {
            return CheckTheUserInfo(loginInfo.UserId, loginInfo.Password);
        }
    }
}            