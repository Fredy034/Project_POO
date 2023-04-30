using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawsInn.Clases
{
    public class UserInfo
    {
        UserData userdata = new UserData();
        public bool LoginUser(string user, string pass)
        {
            return userdata.Login(user, pass);
        }

        public string recoverPassword(string userRequesting)
        {
            return userdata.recoverPassword(userRequesting);
        }
    }
}
