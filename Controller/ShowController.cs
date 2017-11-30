using System.Linq;

namespace EAS.Controller
{
    class ShowController
    {
        HDBDataContext Database = new HDBDataContext();


        public ShowController()
        {

        }

        public object InitDataHospitals()
        {
            return Database.Hospitals;
        }

        public object InitDataPatients()
        {
            var str = from x in Database.Users
                      select new { Name = x.Uid, Address = x.UName, Gender = x.PGender };

            return str;
        }

        public void Delete(int index)
        {
            Hospital hos = Database.Hospitals.SingleOrDefault(x => x.Hid == index);

            Database.Hospitals.DeleteOnSubmit(hos);
            Database.SubmitChanges();
            

        }

        


    }
}
