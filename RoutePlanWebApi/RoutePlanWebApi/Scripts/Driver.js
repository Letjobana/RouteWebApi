var apiSettings = {
    testingUrl: "https://localhost:44380/api/",
}
$(document).ready(function () {
    GetDepartment();
    GetSection();
    AddDriver();
    SetDates();
});

function viewModel() {
    var self = this;
    self.firstname = ko.observable();
    self.phonenumber = ko.observable();
    self.email = ko.observable();
    self.departments = ko.observableArray([]);    
    self.selectedDepartment = ko.observable();
    self.sections = ko.observableArray([]);
    self.selectedSection = ko.observable();
    self.linemanager = ko.observable();
    self.licensedetails = ko.observable();
    self.licenseexpiry = ko.observable();

    self.submitDriver = function () {
        var departmentType = self.selectedDepartment().departmentName;
        var sectionType = self.selectedSection().sectionName;
        var Driver = {
            FirstName: self.firstname,
            PhoneNumber: self.phonenumber,
            Email: self.email,
            Department: departmentType,
            Section: sectionType,
            LineManager: self.linemanager,
            LicenseNumber: self.licensedetails,
            LicenseExpiry: self.licenseexpiry,
        };
        AddDriver(Driver);
    }
    //self.submitDriver = function (formElement) {
    //    AddDriver(formElement.firstname.value, formElement.phonenumber.value, formElement.email.value, formElement.department.value, formElement.section.value, formElement.linemanager.value, formElement.licensedetails.value, formElement.licenseexpiry.value);
    //};

    //self.addDriver= function (data, event) {

    //    var target = event.target || event.srcElement;

    //    if (target.nodeType == 3) 
    //        target = target.parentNode;

    //    target.parentNode.innerHTML = "something";
    //}


}

var mainModel = new viewModel();
/*function AddDriver(firstname, phonenumber, email, department, section,linemanager,licensedetails, licenseexpiry) {*/
function AddDriver(Driver) {
    //var driver = {
    //    FirstName: firstname,
    //    PhoneNumber: phonenumber,
    //    Email: email,
    //    Department: department,
    //    Section: section,
    //    LineManager: linemanager,
    //    LicenseNumber: licensedetails,
    //    LicenseExpiry: licenseexpiry
    //};

    $.ajax({
        type: "POST",
        url: apiSettings.testingUrl + "driver/adddriver",
        data: Driver,
        success: function (data) {
            if (data.Status) {
                MessageBox("Success", "Driver added Successfully", "success", true);


            }

        }, error: function (error) {
            console.log(error);
        }
    });
}
function GetDepartment() {
    

    $.ajax({
        url: apiSettings.testingUrl + "driver/getdepartment",
        type: "Get",        
        success: function (data) {
            mainModel.departments(data);

        }, error: function (error) {
            console.log(error);
        }
    });
}
function GetSection() {


    $.ajax({
        url: apiSettings.testingUrl + "driver/getsection",
        type: "Get",
        success: function (data) {
            mainModel.sections(data);

        }, error: function (error) {
            console.log(error);
        }
    });
}
function SetDates() {
    var licenseexpiryDate = new Date()
    licenseexpiryDate.setHours(0, 0, 0)


    mainModel.licenseexpiry(moment(licenseexpiryDate).format('YYYY-MM-DDTHH:mm'))

    $('#licenseexpiry').val(mainModel.licenseexpiry())

}
$(function () {
    try {
        var isBound = !!ko.dataFor(document.getElementById('mainmodel-container'));
        if (!isBound) {

            ko.applyBindings(mainModel, document.getElementById("mainmodel-container"));
        }


    }
    catch (ex) {
        alert(ex.message);
    }


})

