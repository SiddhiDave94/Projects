using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//This class contains all the properties for get the institute name and number of courses
namespace InstituteFinderAPI.Models
{
    public class Institute
    {
        //This prorperty used to store institute name
        String CollegeName;

        public String C_Name
        {
            get { return CollegeName; }
            set { CollegeName = value; }
        }

        //This property is used to store Institute ID
        int CollegeID;

        public int c_Id
        {
            get { return CollegeID; }
            set { CollegeID = value; }
        }

        //This property is used to store Institute Adress
        String Address;

        public String c_address
        {
            get { return Address; }
            set { Address = value; }
        }

        //This property is used to store Institute City
        String City;

        public String c_city
        {
            get { return City; }
            set { City = value; }
        }

        //This property is used to store Institute Province
        String Province;

        public String c_province
        {
            get { return Province; }
            set { Province = value; }
        }

        //This property is used to store Institute Postal Code
        String PostalCode;

        public String c_postalcode
        {
            get { return PostalCode; }
            set { PostalCode = value; }
        }

        //This property is used to store Institute Contact Details
        String ContactDetails;

        public String c_contact
        {
            get { return ContactDetails; }
            set { ContactDetails = value; }
        }

        //This property is used to store total number of courses for Institute
        String NumOfCourses;

        public String no_courses
        {
            get { return NumOfCourses; }
            set { NumOfCourses = value; }
        }

        //This property is used to store total number of campuses for Institute
        String NumOfCampus;

        public String no_campus
        {
            get { return NumOfCampus; }
            set { NumOfCampus = value; }
        }


        //This property is used to store Course ID
        String CourseID;
        public String courseId
        {
            get { return CourseID; }
            set { CourseID = value; }
        }

        //This property is used to store Course Name
        String CourseName;
        public String courseName
        {
            get { return CourseName; }
            set { CourseName = value; }
        }

        //This property is used to store Institute Name
        String CollgeName;
        public String collegeName
        {
            get { return CollgeName; }
            set { CollgeName = value; }
        }

        //This property is used to store Course Legnth
        String CourseLength;
        public String courseLength
        {
            get { return CourseLength; }
            set { CourseLength = value; }
        }

        //This property is used to store number of leves for Course
        String NumOfLevels;
        public String noOfLevels
        {
            get { return NumOfLevels; }
            set { NumOfLevels = value; }
        }

        //This property is used to store CampusOffering for Course
        String CampusOffering;
        public String campusOffering
        {
            get { return CampusOffering; }
            set { CampusOffering = value; }
        }

        //This property is used to store Institute DLI number
        String DLINumber;
        public String dliNumber
        {
            get { return DLINumber; }
            set { DLINumber = value; }
        }

        //Course Details Properties
        //This property is used to store course Id
        String CourseId;
        public String courseID
        {
            get { return CourseId; }
            set { CourseId = value; }
        }

        //This property is used to store number of courses
        String NumOfCourse;
        public String numOfCourses
        {
            get { return NumOfCourse; }
            set { NumOfCourse = value; }
        }

        //This property is used to store Course details
        String CourseDetails;
        public String courseDetails
        {
            get { return CourseDetails; }
            set { CourseDetails = value; }
        }

        //This property is used to store Tution fees
        String TutionFees;
        public String tutionFees
        {
            get { return TutionFees; }
            set { TutionFees = value; }
        }

        //This property is used to store Course start date
        String StartDate;
        public String startDate
        {
            get { return StartDate; }
            set { StartDate = value; }
        }


        //This property is used to store Course end date
        String EndDate;
        public String endDate
        {
            get { return EndDate; }
            set { EndDate = value; }
        }

        //This property is used to store student type
        String StudentType;
        public String studentType
        {
            get { return StudentType; }
            set { StudentType = value; }
        }

        //This property is used to store Program Code
        String ProgramCode;
        public String programCode
        {
            get { return ProgramCode; }
            set { ProgramCode = value; }
        }

        //This property is used to store Academic Code
        String AcademicSchool;
        public String academicCode
        {
            get { return AcademicSchool; }
            set { AcademicSchool = value; }
        }


        //This property is used to store CoordinatorName
        String CoordinatorName;
        public String coordinatorName
        {
            get { return CoordinatorName; }
            set { CoordinatorName = value; }
        }

        //This property is used to store Program delivery type
        String DeliveryType;
        public String deliveryType
        {
            get { return DeliveryType; }
            set { DeliveryType = value; }
        }

        //This property is used to store Program Credentials
        String Credentials;
        public String credentials
        {
            get { return Credentials; }
            set { Credentials = value; }
        }

        //This property is used to store Course duration
        String CourseDuration;
        public String courseDuration
        {
            get { return CourseDuration; }
            set { CourseDuration = value; }
        }

    }

   
}