using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelWeb.Models.DB;
using TravelWeb.Models.ViewModel;

namespace TravelWeb.Models.EntityManager
{
    public class HutuchManager
    {
        public string AddUserAccount(HutuchModel hutuch)
        {

            using (Database1Entities db = new Database1Entities())//baazin ner
            {
                try
                {
                    Hutuch hu = new Hutuch();
                    hu.hutuchId = hutuch.hutuchId;
                    hu.name = hutuch.name;
                    hu.email = hutuch.email;
                    hu.registerNo = hutuch.registerNo;
                    hu.phone = hutuch.phone;
                    hu.password = hutuch.password;
                    hu.address = hutuch.address;
                    hu.birthDate = hutuch.birthDate;
                    hu.gender = hutuch.gender;

                    db.Hutuches.Add(hu);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                return "1";
            }
        }

        public bool IsLoginNameExist(string loginName)
        {
            using (Database1Entities db = new Database1Entities())
            {
                return db.Hutuches.Where(o => o.email.Equals(loginName)).Any();
            }
        }
    }
}