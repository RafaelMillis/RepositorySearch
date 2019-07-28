

(function () {

    'use strict';

    angular.

        module('core').

        factory('configurationService', configurationService);

    configurationService.$inject = ['$http'];

    function configurationService($http) {

        var configurationObject = {};

        function init() {

            return $http.get('config/config.json').then(function (response) {

                configurationObject = response.data;

            });

        }

        function getConfigByKey(key) {

            return configurationObject[key];

        }

        return {

            init: init,

            getConfigByKey: getConfigByKey

        };

    }

}());

