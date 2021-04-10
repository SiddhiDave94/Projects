using InstituteFinderApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstituteFinderApplication.Controllers
{
    public class CollegeController : Controller
    {
        //This variable use to fectch records based on selected college from database
        string CDLINumber;

        /// <summary>  
        ///   
        /// Get All College List  
        /// </summary>  
        /// <returns></returns>  
        public JsonResult Get_AllCollege()
        {
            //This will get the data from InstituteFinderDB Entity which is store in web config file
            using (InstituteFinderDBEntities Obj = new InstituteFinderDBEntities())
            {
                //College model is under the Model Folder
                    List<College> Emp = Obj.Colleges.ToList();
                return Json(Emp, JsonRequestBehavior.AllowGet);
            }
        }

        /// <summary>  
        ///   
        /// Get All Course  List  
        /// </summary>  
        /// <returns></returns> 
        public JsonResult Get_AllCourse()
        {
            //This will get the data from InstituteFinderDB Entity which is store in web config file
            using (CourseEntities Obj = new CourseEntities())
            {
                CDLINumber = HomeController.TempID;
                //Course model is under the Model Folder
                List<Cours> course = Obj.Courses.ToList();
                return Json(course.Where(d => d.DLINumber == CDLINumber).ToList(), JsonRequestBehavior.AllowGet);
            }
        }
    }
}