mainApp.controller('ContactController', function ($scope, $http) {
    $("#contactmenu").addClass("active");
    
    $scope.SendMessage = (Model) => {
        console.log(Model);
        var sendMessage = $http({
            method: 'POST',
            url: '/Home/SendMessage',
            dataType: 'json',
            data: Model

        }).then(function successCallback(response) {
            $scope.saveErrors = [];
            if (response.data.success === false) {
                for (var i = 0; i < response.data.errors.length; i++) {
                    for (var e = 0; e < response.data.errors[i].Errors.length; e++) {
                        $scope.saveErrors.push(response.data.errors[i].Errors[e]);
                    }
                }
            }
            else {
            }

        }).then(function errorCallback(response) {
        });
    };
});