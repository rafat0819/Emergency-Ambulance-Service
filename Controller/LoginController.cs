using System.Linq;
using System.Windows.Forms;

namespace EAS.Controller
{
    class LoginController
    {
        HDBDataContext Database = new HDBDataContext();
        Form frm;

        public LoginController(Form frm)
        {
            this.frm = frm;
        }

        public bool Login(string Username, string Password)
        {
            bool result = false;

            User user = Database.Users.SingleOrDefault(x => x.UName == Username);
            if (user != null)
            {
                if (user.UPas == Password)
                {
                    result = true;
                    Properties.Settings.Default.uid = user.Uid;
                }
                else {
                    result = false;
                }
            }
            else {
                result = false;
            }

            return result;
        }

        public bool checkType(string Username)
        {
            bool result = false;

            User user = Database.Users.SingleOrDefault(x => x.UName == Username);

            if (user.UType_ == true)
            {
                result = true;
            }
            else
            {
                result = false;
            }


            return result;
        }
    }
}
