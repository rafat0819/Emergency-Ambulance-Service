using System;
using System.Windows.Forms;

namespace EAS.Controller
{
    class AddHospitalController
    {
        HDBDataContext Database = new HDBDataContext();
        Hospital newHospital = new Hospital();
        Form frm;

        public string str;

        public AddHospitalController(Form frm)
        {
            this.frm = frm;
        }

        public bool Step1(string name, string city, string country)
        {

            try
            {
                newHospital.HName = name;
                newHospital.HCity = city;
                newHospital.HCountry = country;

                 str = city + ", " + country;

                

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return false;
            }

        }

        public bool Step2(double lat, double lng)
        {
            bool result = false;

            try
            {
                newHospital.HLat = lat;
                newHospital.HLng = lng;



                result = true;
                if (insert())
                {

                    result = true;
                    MessageBox.Show("Thanks for registerting in our system !");
                    new Show().Show();
                    this.frm.Hide();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                result = false;
            }

            return result;
        }

        public bool insert()
        {
            try
            {
                Database.Hospitals.InsertOnSubmit(newHospital);
                Database.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return false;
            }

        }



    }
}
