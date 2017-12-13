

////FormController
    var FormController;

//    //Cria um Module
//    var App = angular.module('App', []);

////Cria um Controller e registra no Module
//    App.controller('FormController', function ($scope) {

//        $scope.resetForm = function () {
//            $scope.FormCad.$setPristine();
//            $scope.FormCad.$setUntouched();
//        }

//        // $scope é usado para compartilhar dados entre a view e o controller
//        FormController = $scope;
        
//    });



    // Defining angularjs application.
    var postApp = angular.module('App', []);
    // Controller function and passing $http service and $scope var.
    postApp.controller('FormController', function ($scope, $http) {

        $scope.Usuario = {};
        FormController = $scope;

        // create a blank object to handle form data.
        //$scope.FormCad = {};
      // calling our submit function.
        $scope.submit = function () {
        // Posting data to ConsultaUsuario file
        $http.post('/api/usuario', $scope.Usuario)
          .success(function (data) {

              var myJsonString = JSON.stringify(data);

              var jsonArray = JSON.parse(JSON.stringify(data))
          });
        };
    });