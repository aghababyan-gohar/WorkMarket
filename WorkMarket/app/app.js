'use strict';

(function () {
    var app = angular.module('workMarketApp', ['ngRoute', 'LocalStorageModule', 'angular-loading-bar']);

    app.config(function ($routeProvider) {
        $routeProvider.when("/home", {
            controller: "homeController",
            templateUrl: "components/home/home.html"
        });

        $routeProvider.when("/login", {
            controller: "loginController",
            templateUrl: "components/login/login.html"
        });

        $routeProvider.when("/signup", {
            controller: "signupController",
            templateUrl: "components/signup/signup.html"
        });

        $routeProvider.when("/orders", {
            controller: "ordersController",
            templateUrl: "components/orders/orders.html"
        });

        $routeProvider.otherwise({ redirectTo: "/home" });
    });

    app.config(function ($httpProvider) {
        $httpProvider.interceptors.push('authInterceptorService');
    });

    app.run(['authService', function (authService) {
        authService.fillAuthData();
    }]);

}());