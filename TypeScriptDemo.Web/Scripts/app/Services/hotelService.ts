module app {
    'use strict';
    export interface IHotelService {
        getHotels: () => ng.IPromise<any>;
    }

    class HotelService implements IHotelService {
        getHotels: () => ng.IPromise<any>;

        static $inject = ['webRequest'];
        constructor(webRequest : IWebRequest) {
            var vm = this;

            vm.getHotels = (): ng.IPromise<any>=> {
                return webRequest.get<any>('/hotel').then(result => result.data);
            }
        }
    }

    angular.module('app').service('hotelService', HotelService);
}