using System.Linq;
using codemasters.BusinessLogic.DBModel;
using codemasters.Domain.Entities.User;

namespace codemasters.BusinessLogic.Core
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            UDbTable user;

            using (var db = new UserContext())
            {
                user = db.Users.FirstOrDefault(u => u.Username == data.Credential);
            }

            using (var db = new UserContext())
            {
                user = (from u in db.Users where u.Username == data.Credential select u).FirstOrDefault();
            }


            if (user != null)
            {

            }

            return new ULoginResp();
        }
    }
}
