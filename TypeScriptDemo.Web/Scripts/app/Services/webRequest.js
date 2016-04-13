var app;
(function (app) {
    'use strict';
    var WebRequest = (function () {
        function WebRequest($http, $timeout) {
            this.$http = $http;
        }
        WebRequest.prototype.get = function (url, params) {
            return this.httpRequest("GET", url, params);
        };
        WebRequest.prototype.httpRequest = function (method, url, data) {
            var _this = this;
            var request = this.$http({
                method: method,
                url: url,
                params: data
            }).success(function (data) { return _this.$q.resolve(data); });
            return request;
        };
        return WebRequest;
    })();
    factory.$inject = ['$http', '$timeout'];
    function factory($http, $timeout) {
        return new WebRequest($http, $timeout);
    }
    angular.module('app').factory('webRequest', factory);
})(app || (app = {}));
//# sourceMappingURL=webRequest.js.map