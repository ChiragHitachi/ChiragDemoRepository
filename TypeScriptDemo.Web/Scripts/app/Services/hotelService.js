var app;
(function (app) {
    'use strict';
    var HotelService = (function () {
        function HotelService(webRequest) {
            var vm = this;
            vm.getHotels = function () {
                return webRequest.get('/hotel').then(function (result) { return result.data; });
            };
        }
        HotelService.$inject = ['webRequest'];
        return HotelService;
    })();
    angular.module('app').service('hotelService', HotelService);
})(app || (app = {}));
//# sourceMappingURL=hotelService.js.map