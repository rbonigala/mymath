// Write your Javascript code.

$(document).ready(function(){
$("#status").html("");
    $("#btnCheckAnswer").click(function(){
        var result = $("#result").val();
        var givenanswer = $("#GivenAnswerTxt").val();
        if(result == givenanswer)
        {
            $("#status").html("Correct").css("color", "green");

        }
        else
        {
            $("#status").html("Try Again").css("color", "red");
        }
        return false;
     });
    
})

