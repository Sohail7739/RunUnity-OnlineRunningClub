angular.module('myApp', [])
    .controller('DisplayByNameController', ['$scope', '$http', function ($scope, $http) {
        $http.get('/api/clubs/byName')
            .then(function (response) {
                $scope.clubs = response.data;
            });
    }]);
