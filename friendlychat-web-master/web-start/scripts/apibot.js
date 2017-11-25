    $(document).ready(
        function () {
            var dataJSON = { 'message': "Hello" };
            $('#submit').click(
                function () {
                    $.ajax({                        
                        url: 'http://localhost:54708/api/AskPlaces/Reply',
			contentType: 'application/json; charset=utf-8',
                        data: dataJSON,
                        type: 'POST',
			traditional: true,
                        dataType: 'json'
                    });
                }
            );
        }
    );