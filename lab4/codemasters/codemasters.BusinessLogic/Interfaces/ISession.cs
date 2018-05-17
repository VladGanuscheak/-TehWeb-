using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using codemasters.Domain.Entities.User;

namespace codemasters.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
        //HttpCookie GenCookie(string credential);
        UserMinimal GetUserByCookie(string apiCookieValue);
    }
}