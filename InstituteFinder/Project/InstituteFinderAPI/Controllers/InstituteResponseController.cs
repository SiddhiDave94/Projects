using InstituteFinderAPI.Models;
using InstituteFinderAPI.Views.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//This class will set the value for college name and number of courses 
namespace InstituteFinderAPI.Controllers
{
    public class InstituteResponseController : ApiController
    {
        public InstituteDataResponse AddInstitute(Institute objinst)
        {
            InstituteDataResponse instdataresp = new InstituteDataResponse();
            InstituteData.getInstance().Add(objinst);
            instdataresp.C_Name = objinst.C_Name;
            instdataresp.c_Id = objinst.c_Id;
            instdataresp.c_address = objinst.c_address;
            instdataresp.c_city = objinst.c_city;
            instdataresp.c_province = objinst.c_province;
            instdataresp.c_postalcode = objinst.c_postalcode;
            instdataresp.c_contact = objinst.c_contact;
            instdataresp.no_courses = objinst.no_courses;
            instdataresp.no_campus = objinst.no_campus;
            instdataresp.courseId = objinst.courseId;
            instdataresp.courseName = objinst.courseName;
            instdataresp.collegeName = objinst.collegeName;
            instdataresp.courseLength = objinst.courseLength;
            instdataresp.noOfLevels = objinst.noOfLevels;
            instdataresp.campusOffering = objinst.campusOffering;
            instdataresp.dliNumber = objinst.dliNumber;
            instdataresp.courseID = objinst.courseID;
            instdataresp.numOfCourses = objinst.numOfCourses;
            instdataresp.courseDetails = objinst.courseDetails;
            instdataresp.tutionFees = objinst.tutionFees;
            instdataresp.startDate = objinst.startDate;
            instdataresp.endDate = objinst.endDate;
            instdataresp.studentType = objinst.studentType;
            instdataresp.programCode = objinst.programCode;
            instdataresp.academicCode = objinst.academicCode;
            instdataresp.coordinatorName = objinst.coordinatorName;
            instdataresp.deliveryType = objinst.deliveryType;
            instdataresp.credentials = objinst.credentials;
            instdataresp.courseDuration = objinst.courseDuration;
            instdataresp.Status = "Sucess";
            List<Institute> DBList = new List<Institute>();
            if (instdataresp != null)
            {
                DBList.Add(objinst);
                Database db = new Database();
                db.connectDB(DBList);

            }
            return instdataresp;
        }

    }
}
