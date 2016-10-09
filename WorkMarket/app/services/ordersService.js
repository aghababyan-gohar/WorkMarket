'use strict';

(function () {
    var app = angular.module('workMarketApp');

    app.factory('ordersService', ['$http', function ($http) {

        var serviceBase = 'http://localhost:60112/';
        var ordersServiceFactory = {};

        var _getOrders = function () {

            return $http.get(serviceBase + 'api/Orders').then(function (results) {
                return results;
            });
        };

        ordersServiceFactory.getOrders = _getOrders;

        return ordersServiceFactory;

    }]);
}());