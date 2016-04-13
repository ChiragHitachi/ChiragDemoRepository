module app {
    'use strict';

    angular.module('app').directive('hotelDropdown', HotelDropdown);

    function HotelDropdown(): ng.IDirective {
        var directive = <ng.IDirective>{
            restrict: 'EA',
            scope: {
                selectedHotel: '=',
                onHotelChange: '=?',
                id: '@?',
            },
            templateUrl: 'hotelDropdown.html',
            controller: hotelDropdownController,
            controllerAs: 'vm',
            bindToController :  true,
        };
        return directive;
    }

    export class hotelDropdownController {
        hotels: any[]
        static $inject = ['$scope', '$element', 'hotelService']
        constructor($scope: ng.IScope, element: ng.IAugmentedJQuery, hotelService : IHotelService) {
            var vm = this;

            getHotels();

            function getHotels() {
                if (!vm.hotels) {
                    hotelService.getHotels().then((data) => { vm.hotels = data });
                }
            }
        }
    }
}