var app = angular.module('MovieApp', []);
app.controller('MovieController', function ($scope) {
    $scope.appName = "MovieApp";
    var appName1 = "Darshan";

    $scope.input1 = 5;
    $scope.input2 = 8;

    $scope.names = [
        { name: 'Jani', country: 'Norway' },
        { name: 'Hege', country: 'Sweden' },
        { name: 'Kai', country: 'Denmark' }];

});