mainApp.controller('BlogController', function ($scope, $http) {
    $("#blogmenu").addClass("active");

   

    $scope.AddComment = (Comment) => {
        var data = { Comment: Comment, articleId: $scope.articleId };
        var addComment = $http({
            method: 'POST',
            url: '/Blog/AddComment',
            dataType: 'json',
            data: data

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
                window.location.reload();
            }
        }).then(function errorCallback(response) {
        });
    }
});