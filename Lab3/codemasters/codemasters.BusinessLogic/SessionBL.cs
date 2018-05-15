using codemasters.BusinessLogic.Core;
using codemasters.BusinessLogic.Interfaces;
using codemasters.Domain.Entities.User;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codemasters.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            throw new NotImplementedException();
        }

        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }

        /*public HttpCookie GenCookie(string loginCredential)
        {
            return Cookie(loginCredential);
        }

        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }*/
    }
}
