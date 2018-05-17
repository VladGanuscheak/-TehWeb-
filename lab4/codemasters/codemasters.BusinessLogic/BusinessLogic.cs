using codemasters.BusinessLogic.Interfaces;

namespace codemasters.BusinessLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
    }
}
