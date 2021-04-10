using InstituteFinderAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

//This class will connect with database and make call to insert the data in database
namespace InstituteFinderAPI.Views.Database
{
    public class Database
    {
        public void connectDB(List<Institute> data)
        {
            try
            {

                SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=InstituteFinderDB;Integrated Security=True");
                conn.Open();

                string stmt = "INSERT INTO College (CollegeName, DLINumber, Address, City, Province, PostalCode, ContactDetails, NumOfCourses, NumOfCampus) VALUES (@CollegeName, @DLINumber, @Address, @City, @Province, @PostalCode, @ContactDetails, @NumOfCourses, @NumOfCampus)";

                SqlCommand cmd = new SqlCommand(stmt, conn);

                cmd.Parameters.Add("@CollegeName", SqlDbType.VarChar);
                cmd.Parameters["@CollegeName"].Value = data[0].collegeName;

                cmd.Parameters.Add("@DLINumber", SqlDbType.VarChar);
                cmd.Parameters["@DLINumber"].Value = data[0].dliNumber;

                cmd.Parameters.Add("@Address", SqlDbType.VarChar);
                cmd.Parameters["@Address"].Value = data[0].c_address;

                cmd.Parameters.Add("@City", SqlDbType.VarChar);
                cmd.Parameters["@City"].Value = data[0].c_city;

                cmd.Parameters.Add("@Province", SqlDbType.VarChar);
                cmd.Parameters["@Province"].Value = data[0].c_province;

                cmd.Parameters.Add("@PostalCode", SqlDbType.VarChar);
                cmd.Parameters["@PostalCode"].Value = data[0].c_postalcode;

                cmd.Parameters.Add("@ContactDetails", SqlDbType.VarChar);
                cmd.Parameters["@ContactDetails"].Value = data[0].c_contact;

                cmd.Parameters.Add("@NumOfCourses", SqlDbType.Int);
                cmd.Parameters["@NumOfCourses"].Value = Convert.ToInt32(data[0].no_courses);

                cmd.Parameters.Add("@NumOfCampus", SqlDbType.Int);
                cmd.Parameters["@NumOfCampus"].Value = Convert.ToInt32(data[0].no_campus);


                cmd.ExecuteNonQuery();

                stmt = "INSERT INTO Courses (CourseID , CourseName ,  CollegeName , CourseLength, NumofLevels, CampusOffering, DLINumber) VALUES ( @CourseID, @CourseName, @CollegeName, @CourseLength, @NumofLevels, @CampusOffering, @DLINumber)";

                cmd = new SqlCommand(stmt, conn);

                cmd.Parameters.Add("@CourseID", SqlDbType.Int);
                cmd.Parameters["@CourseID"].Value = Convert.ToInt32(data[0].courseId);

                cmd.Parameters.Add("@CourseName", SqlDbType.VarChar);
                cmd.Parameters["@CourseName"].Value = data[0].courseName;

                cmd.Parameters.Add("@CollegeName", SqlDbType.VarChar);
                cmd.Parameters["@CollegeName"].Value = data[0].collegeName;

                cmd.Parameters.Add("@CourseLength", SqlDbType.VarChar);
                cmd.Parameters["@CourseLength"].Value = data[0].courseLength;

                cmd.Parameters.Add("@NumofLevels", SqlDbType.VarChar);
                cmd.Parameters["@NumofLevels"].Value = data[0].noOfLevels;

                cmd.Parameters.Add("@CampusOffering", SqlDbType.VarChar);
                cmd.Parameters["@CampusOffering"].Value = data[0].campusOffering;

                cmd.Parameters.Add("@DLINumber", SqlDbType.VarChar);
                cmd.Parameters["@DLINumber"].Value = data[0].dliNumber;


                cmd.ExecuteNonQuery();

                /*
                stmt = "INSERT INTO CourseDetails (CourseID, NumOfCourses, CourseDetails , TutionFees, StartDate, EndDate, StudentType, ProgramCode, AcamedicSchool, CoordinatorName, DeliveryType, Credential, CourseDuration) VALUES ( @CourseID, @NumOfCourses, @CourseDetails , @TutionFees, @StartDate, @EndDate, @StudentType, @ProgramCode, @AcamedicSchool, @CoordinatorName, @DeliveryType, @Credential, @CourseDuration)";

                cmd = new SqlCommand(stmt, conn);

                cmd.Parameters.Add("@CourseID", SqlDbType.Int);
                cmd.Parameters["@CourseID"].Value = Convert.ToInt32(data[0].courseID);

                cmd.Parameters.Add("@NumOfCourses", SqlDbType.VarChar);
                cmd.Parameters["@NumOfCourses"].Value = data[0].numOfCourses;

                cmd.Parameters.Add("@CourseDetails", SqlDbType.VarChar);
                cmd.Parameters["@CourseDetails"].Value = data[0].courseDetails;

                cmd.Parameters.Add("@TutionFees", SqlDbType.VarChar);
                cmd.Parameters["@TutionFees"].Value = data[0].tutionFees;

                cmd.Parameters.Add("@StartDate", SqlDbType.VarChar);
                cmd.Parameters["@StartDate"].Value = data[0].startDate;

                cmd.Parameters.Add("@EndDate", SqlDbType.VarChar);
                cmd.Parameters["@EndDate"].Value = data[0].endDate;

                cmd.Parameters.Add("@StudentType", SqlDbType.VarChar);
                cmd.Parameters["@StudentType"].Value = data[0].studentType;

                cmd.Parameters.Add("@ProgramCode", SqlDbType.VarChar);
                cmd.Parameters["@ProgramCode"].Value = data[0].programCode;

                cmd.Parameters.Add("@AcamedicSchool", SqlDbType.VarChar);
                cmd.Parameters["@AcamedicSchool"].Value = data[0].academicCode;

                cmd.Parameters.Add("@CoordinatorName", SqlDbType.VarChar);
                cmd.Parameters["@CoordinatorName"].Value = data[0].coordinatorName;

                cmd.Parameters.Add("@DeliveryType", SqlDbType.VarChar);
                cmd.Parameters["@DeliveryType"].Value = data[0].deliveryType;

                cmd.Parameters.Add("@Credential", SqlDbType.VarChar);
                cmd.Parameters["@Credential"].Value = data[0].credentials;

                cmd.Parameters.Add("@CourseDuration", SqlDbType.VarChar);
                cmd.Parameters["@CourseDuration"].Value = data[0].courseDuration;

                cmd.ExecuteNonQuery();
                */
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateDB(List<Institute> data, string DLINumber)
        {
            try
            {

                SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=InstituteFinderDB;Integrated Security=True");
                conn.Open();

                string stmt = "UPDATE College SET CollegeName = @CollegeName, DLINumber = @DLINumber, Address = @Address, City = @City, Province = @Province, PostalCode = @PostalCode, ContactDetails = @ContactDetails, NumOfCourses = @NumOfCourses, NumOfCampus = @NumOfCampus WHERE DLINumber = ";
                string updateStm = String.Concat(stmt, DLINumber);
                SqlCommand cmd = new SqlCommand(updateStm, conn);

                cmd.Parameters.Add("@CollegeName", SqlDbType.VarChar);
                cmd.Parameters["@CollegeName"].Value = data[0].collegeName;

                cmd.Parameters.Add("@DLINumber", SqlDbType.VarChar);
                cmd.Parameters["@DLINumber"].Value = data[0].dliNumber;

                cmd.Parameters.Add("@Address", SqlDbType.VarChar);
                cmd.Parameters["@Address"].Value = data[0].c_address;

                cmd.Parameters.Add("@City", SqlDbType.VarChar);
                cmd.Parameters["@City"].Value = data[0].c_city;

                cmd.Parameters.Add("@Province", SqlDbType.VarChar);
                cmd.Parameters["@Province"].Value = data[0].c_province;

                cmd.Parameters.Add("@PostalCode", SqlDbType.VarChar);
                cmd.Parameters["@PostalCode"].Value = data[0].c_postalcode;

                cmd.Parameters.Add("@ContactDetails", SqlDbType.VarChar);
                cmd.Parameters["@ContactDetails"].Value = data[0].c_contact;

                cmd.Parameters.Add("@NumOfCourses", SqlDbType.Int);
                cmd.Parameters["@NumOfCourses"].Value = Convert.ToInt32(data[0].no_courses);

                cmd.Parameters.Add("@NumOfCampus", SqlDbType.Int);
                cmd.Parameters["@NumOfCampus"].Value = Convert.ToInt32(data[0].no_campus);


                cmd.ExecuteNonQuery();

                stmt = "UPDATE Courses SET CourseID = @CourseID, CourseName = @CourseName,  CollegeName = @CollegeName, CourseLength = @CourseLength, NumofLevels = @NumofLevels, CampusOffering = @CampusOffering, DLINumber = @DLINumber WHERE DLINumber = ";
                String updateCourses = String.Concat(stmt, DLINumber);
                cmd = new SqlCommand(updateCourses, conn);

                cmd.Parameters.Add("@CourseID", SqlDbType.Int);
                cmd.Parameters["@CourseID"].Value = Convert.ToInt32(data[0].courseId);

                cmd.Parameters.Add("@CourseName", SqlDbType.VarChar);
                cmd.Parameters["@CourseName"].Value = data[0].courseName;

                cmd.Parameters.Add("@CollegeName", SqlDbType.VarChar);
                cmd.Parameters["@CollegeName"].Value = data[0].collegeName;

                cmd.Parameters.Add("@CourseLength", SqlDbType.VarChar);
                cmd.Parameters["@CourseLength"].Value = data[0].courseLength;

                cmd.Parameters.Add("@NumofLevels", SqlDbType.VarChar);
                cmd.Parameters["@NumofLevels"].Value = data[0].noOfLevels;

                cmd.Parameters.Add("@CampusOffering", SqlDbType.VarChar);
                cmd.Parameters["@CampusOffering"].Value = data[0].campusOffering;

                cmd.Parameters.Add("@DLINumber", SqlDbType.VarChar);
                cmd.Parameters["@DLINumber"].Value = data[0].dliNumber;


                cmd.ExecuteNonQuery();

                /*
                stmt = "INSERT INTO CourseDetails (CourseID, NumOfCourses, CourseDetails , TutionFees, StartDate, EndDate, StudentType, ProgramCode, AcamedicSchool, CoordinatorName, DeliveryType, Credential, CourseDuration) VALUES ( @CourseID, @NumOfCourses, @CourseDetails , @TutionFees, @StartDate, @EndDate, @StudentType, @ProgramCode, @AcamedicSchool, @CoordinatorName, @DeliveryType, @Credential, @CourseDuration)";

                cmd = new SqlCommand(stmt, conn);

                cmd.Parameters.Add("@CourseID", SqlDbType.Int);
                cmd.Parameters["@CourseID"].Value = Convert.ToInt32(data[0].courseID);

                cmd.Parameters.Add("@NumOfCourses", SqlDbType.VarChar);
                cmd.Parameters["@NumOfCourses"].Value = data[0].numOfCourses;

                cmd.Parameters.Add("@CourseDetails", SqlDbType.VarChar);
                cmd.Parameters["@CourseDetails"].Value = data[0].courseDetails;

                cmd.Parameters.Add("@TutionFees", SqlDbType.VarChar);
                cmd.Parameters["@TutionFees"].Value = data[0].tutionFees;

                cmd.Parameters.Add("@StartDate", SqlDbType.VarChar);
                cmd.Parameters["@StartDate"].Value = data[0].startDate;

                cmd.Parameters.Add("@EndDate", SqlDbType.VarChar);
                cmd.Parameters["@EndDate"].Value = data[0].endDate;

                cmd.Parameters.Add("@StudentType", SqlDbType.VarChar);
                cmd.Parameters["@StudentType"].Value = data[0].studentType;

                cmd.Parameters.Add("@ProgramCode", SqlDbType.VarChar);
                cmd.Parameters["@ProgramCode"].Value = data[0].programCode;

                cmd.Parameters.Add("@AcamedicSchool", SqlDbType.VarChar);
                cmd.Parameters["@AcamedicSchool"].Value = data[0].academicCode;

                cmd.Parameters.Add("@CoordinatorName", SqlDbType.VarChar);
                cmd.Parameters["@CoordinatorName"].Value = data[0].coordinatorName;

                cmd.Parameters.Add("@DeliveryType", SqlDbType.VarChar);
                cmd.Parameters["@DeliveryType"].Value = data[0].deliveryType;

                cmd.Parameters.Add("@Credential", SqlDbType.VarChar);
                cmd.Parameters["@Credential"].Value = data[0].credentials;

                cmd.Parameters.Add("@CourseDuration", SqlDbType.VarChar);
                cmd.Parameters["@CourseDuration"].Value = data[0].courseDuration;

                cmd.ExecuteNonQuery();
                */
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void deleteDB(String DLINumber)
        {
            try
            {

                SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=InstituteFinderDB;Integrated Security=True");
                conn.Open();

                string stmt = "DELETE FROM Courses WHERE DLINumber = ";
                string mstmt = String.Concat(stmt, DLINumber);
                SqlCommand cmd = new SqlCommand(mstmt, conn);

                cmd.ExecuteNonQuery();


                stmt = "DELETE FROM College WHERE DLINumber = ";
                mstmt = String.Concat(stmt, DLINumber);
                cmd = new SqlCommand(mstmt, conn);

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}