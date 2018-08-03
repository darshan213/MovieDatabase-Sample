var app = angular.module('MovieApp', []);
app.controller('MovieController', function ($scope, $http) {
    $scope.appName = "MovieApp";
    var appName1 = "Darshan";

    $scope.input1 = 5;
    $scope.input2 = 8;

    // This Function is for http post, also by doing this function it will call the input and put it in the database that is attached.
    $scope.InsertMovie = function () {
        
        $http({
            method: "POST",//method//
            url: "/Http/InsertMovie",// getting this http from the C# controller that we build name of the controller is HttpController.cs
            dataType: 'json',//type of data
            data: {
                MovieName : $scope.moviename,// calling the ng-controller app from the index.html and each section that gives all the input.
                MovieYear: $scope.movieyear,    
                MovieTime: $scope.movietime,
                MovieLanguage: $scope.movielanguage,
                MovieRelease: $scope.movierelease,
                MovieCountry: $scope.moviecountry,
                Actors: $scope.actors,
                Director: $scope.director,
                },
            headers: { "Content-Type": "application/json" }
        }).then(function successCallback(response) {
            console.log(response);
            var data = response.data;
           
        }, function errorCallback(response) {
            console.log(response);
            $scope.NoResults = true;
        });
    }



});