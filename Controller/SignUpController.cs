using System;
using System.Windows.Forms;


namespace EAS.Controller
{
    class SignUpController
    {
        HDBDataContext Database = new HDBDataContext();
        User newUser = new User();
        Form frm;

        public SignUpController(Form frm)
        {
            this.frm = frm;
        }

        public bool Step1(string username, string password)
        {

            try
            {
                newUser.UName = username;
                newUser.UPas = password;


                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return false;
            }

        }

        public bool Step2(string name, System.Windows.Forms.DateTimePicker DP, bool gender, string mobile, string email)
        {

            try
            {
                try
                {
                    newUser.PName = name;
                }
                catch (Exception e)
                {
                    MessageBox.Show("hoinai");
                }

                newUser.PDOB = DP.Value.Date;
                newUser.PGender = gender;
                newUser.PMobileNo = mobile;
                newUser.PEmail = email;

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return false;
            }

        }

        public bool Step3(string address, double lat, double lng)
        {
            try
            {
                newUser.PAddress = address;
                newUser.PLat = lat;
                newUser.PLng = lng;

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return false;
            }

        }

        public bool Step4(string bloodgrp, bool diab, string sugarl, bool pressure, string avgpressure)
        {
            bool result = false;
            try
            {
                newUser.PBloodGrp = bloodgrp;
                newUser.PDiabetes = diab;
                newUser.PBloodSugar = sugarl;
                newUser.PPressure = pressure;
                newUser.PAvgPressure = avgpressure;

                result = true;
                if (insert())
                {

                    result = true;
                    MessageBox.Show("Thanks for registerting in our system !");
                    new Login().Show();
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
                Database.Users.InsertOnSubmit(newUser);
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
