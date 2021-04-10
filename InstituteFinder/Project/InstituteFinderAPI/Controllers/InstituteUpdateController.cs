using InstituteFinderAPI.Models;
using InstituteFinderAPI.Views.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InstituteFinderAPI.Controllers
{
    public class InstituteUpdateController : ApiController
    {
        public String PutInstituteRecord(Institute objinst)
        {
            Console.WriteLine("In updateStudentRecord");
            String updateString = InstituteData.getInstance().UpdateInstitute(objinst);
            List<Institute> DBList = new List<Institute>();
            if (DBList != null)
            {
                DBList.Add(objinst);
                Database db = new Database();
                db.updateDB(DBList, objinst.dliNumber);

            }
            return updateString;
        }
    }
}
