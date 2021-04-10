var app = angular.module("CoursePage", []);
app.controller("Coursecntrl", function ($scope, $http) {
    //debugger;

    //Get All  Data
    $scope.GetAllData = function () {
        $http({
            method: "get",
            url: "https://localhost:44363/College/Get_AllCourse"
        }).then(function (response) {
            $scope.course = response.data;
        }, function () {
            alert("Error Occur");
        })
    };

    //$scope.Clg = college;

    //$scope.search = function (item) {

    //        if (item.Member.toLowerCase()
    //            .indexOf($scope.searchText.toLowerCase()) != -1 ||
    //            item.name.toLowerCase()
    //                .indexOf($scope.searchText.toLowerCase()) != -1) {
    //            return true;
    //        }


    //    return false;
    //};  
    //Get All  Data

    ////InsertData
    //$scope.InsertData = function () {
    //    var Action = document.getElementById("btnSave").getAttribute("value");
    //    if (Action == "Submit") {
    //        $scope.Employe = {};
    //        $scope.Employe.Emp_Name = $scope.EmpName;
    //        $scope.Employe.Emp_City = $scope.EmpCity;
    //        $scope.Employe.Emp_Age = $scope.EmpAge;
    //        $http({
    //            method: "post",
    //            url: "http://localhost/Employee/Insert_Employee",
    //            datatype: "json",
    //            data: JSON.stringify($scope.Employe)
    //        }).then(function (response) {
    //            alert(response.data);
    //            $scope.GetAllData();
    //            $scope.EmpName = "";
    //            $scope.EmpCity = "";
    //            $scope.EmpAge = "";
    //        })
    //    } else {
    //        $scope.Employe = {};
    //        $scope.Employe.Emp_Name = $scope.EmpName;
    //        $scope.Employe.Emp_City = $scope.EmpCity;
    //        $scope.Employe.Emp_Age = $scope.EmpAge;
    //        $scope.Employe.Emp_Id = document.getElementById("EmpID_").value;
    //        $http({
    //            method: "post",
    //            url: "http://localhost:39209/Employee/Update_Employee",
    //            datatype: "json",
    //            data: JSON.stringify($scope.Employe)
    //        }).then(function (response) {
    //            alert(response.data);
    //            $scope.GetAllData();
    //            $scope.EmpName = "";
    //            $scope.EmpCity = "";
    //            $scope.EmpAge = "";
    //            document.getElementById("btnSave").setAttribute("value", "Submit");
    //            document.getElementById("btnSave").style.backgroundColor = "cornflowerblue";
    //            document.getElementById("spn").innerHTML = "Add New Employee";
    //        })
    //    }
    //}
    ////Insert Data

    ////Delete  Data
    //$scope.DeleteEmp = function (Emp) {
    //    $http({
    //        method: "post",
    //        url: "http://localhost:39209/Employee/Delete_Employee",
    //        datatype: "json",
    //        data: JSON.stringify(Emp)
    //    }).then(function (response) {
    //        alert(response.data);
    //        $scope.GetAllData();
    //    })
    //};
    ////Delete  Data

    ////Update Data
    //$scope.UpdateEmp = function (Emp) {
    //    document.getElementById("EmpID_").value = Emp.Emp_Id;
    //    $scope.EmpName = Emp.Emp_Name;
    //    $scope.EmpCity = Emp.Emp_City;
    //    $scope.EmpAge = Emp.Emp_Age;
    //    document.getElementById("btnSave").setAttribute("value", "Update");
    //    document.getElementById("btnSave").style.backgroundColor = "Yellow";
    //    document.getElementById("spn").innerHTML = "Update Employee Information";
    //}
    ////Update Data
})  