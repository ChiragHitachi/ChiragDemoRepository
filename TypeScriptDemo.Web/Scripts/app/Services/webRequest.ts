module app {
    'use strict';

    export interface IWebRequest {
        get<T>(url: string, params?: any): ng.IPromise<T>;
        httpRequest<T>(method: string, url: string, data?: any): ng.IPromise<T>
    }

    class WebRequest implements IWebRequest {
        $q: ng.IQService;
        
        constructor(private $http: ng.IHttpService, $timeout: ng.ITimeoutService) {
        }
        get<T>(url: string, params?: any): ng.IPromise<T>{
            return this.httpRequest<T>("GET", url, params);
        }

        httpRequest<T>(method: string, url: string, data?: any): ng.IPromise<T> {
            var request = this.$http({
                method: method,
                url: url,
                params: data
            }).success((data) => { return this.$q.resolve(data) });
            
            return request;
        }
    }
    factory.$inject = ['$http', '$timeout'];
    function factory($http, $timeout) {
        return new WebRequest($http, $timeout);
    }
    angular.module('app').factory('webRequest', factory);
}