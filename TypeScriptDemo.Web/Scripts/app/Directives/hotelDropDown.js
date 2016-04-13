var app;
(function (app) {
    'use strict';
    angular.module('app').directive('hotelDropdown', HotelDropdown);
    function HotelDropdown() {
        var directive = {
            restrict: 'EA',
            scope: {
                selectedHotel: '=',
                onHotelChange: '=?',
                id: '@?',
            },
            templateUrl: 'hotelDropdown.html',
            controller: hotelDropdownController,
            controllerAs: 'vm',
            bindToController: true,
        };
        return directive;
    }
    var hotelDropdownController = (function () {
        function hotelDropdownController($scope, element, hotelService) {
            var vm = this;
            getHotels();
            function getHotels() {
                if (!vm.hotels) {
                    hotelService.getHotels().then(function (data) { vm.hotels = data; });
                }
            }
        }
        hotelDropdownController.$inject = ['$scope', '$element', 'hotelService'];
        return hotelDropdownController;
    })();
    app.hotelDropdownController = hotelDropdownController;
})(app || (app = {}));
//# sourceMappingURL=hotelDropDown.js.map