var searchCtrl = function ($scope, $http) {

    //movies search
    $scope.getSearchMoviesResults = function () {
        $http.get("http://localhost:50974/api/movies/Search?searchWord=" + $scope.textSearch)
            .then(function (response) {
                $scope.dataResult = response.data;
                console.info(response.data);
            });
    };

    //categories list (shold get it from json)
    $scope.categories = [
        { category: "Name", value: "name" },
        { category: "Series", value: "series" },
        { category: "Season", value: "season" }
    ];
};


