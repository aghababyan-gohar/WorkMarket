(function () {
    var app = angular.module('workMarketApp');

    app.controller('mainController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

        $scope.logOut = function () {
            authService.logOut();
            $location.path('/home');
        }

        $scope.authentication = authService.authentication;

    }]);
}());