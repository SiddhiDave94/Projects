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
    public class DeleteInstituteController : ApiController
    {
        //[Route("student/remove/{regdNum}")]

        public String DeleteCollegeRecord(Institute objinst)
        {
            Console.WriteLine("In deleteStudentRecord");
            String deleteString = InstituteData.getInstance().Remove(objinst);
            List<Institute> DBList = new List<Institute>();
            if (DBList != null)
            {
                DBList.Add(objinst);
                Database db = new Database();
                db.deleteDB(objinst.dliNumber);

            }
            return deleteString;
        }
    }
}
