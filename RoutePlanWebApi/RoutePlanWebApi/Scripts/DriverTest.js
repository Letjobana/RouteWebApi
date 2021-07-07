////var routeSettings = {
  
////};

////$(document).ready(function () {
////    GetReport();
////});

////function ViewModel() {
////    var self = this;  
////    self.Driver = ko.observable();
////    self.Drivers = ko.observableArray();
////}

////var mainModel = new ViewModel();


////function GetReport() {

////    var path = 'https://localhost:44380/api/driver/getdriver';
////    $.ajax(
////        {
////            type: 'Get',
////            url: path,
////            data: {},
////            success: function (data) {
////                mainModel.Drivers(data);
////            } 
////        });
////}

////$(function () {
////    try {
////        var isBound = !!ko.dataFor(document.getElementById('maindiv'));
////        if (!isBound)
////            ko.applyBindings(mainModel);
////    }
////    catch (ex) {
////        alert(ex.message);
////    }
////});

$(document).ready(function () {
    loadData();
});

function DetailsViewModel() {
    var self = this;

    self.driverDetails= ko.observableArray([]);

}
var viewModel = new DetailsViewModel();
ko.applyBindings(viewModel);

function loadData() {
   
    var path = 'https://localhost:44380/api/driver/getdriver';
    $.ajax(
        {
            type: 'Get',
            url: path,
            success: function (data) {
                viewModel.driverDetails(data);
            } 
      }).fail(function () {
            alert("error");
        });

}
