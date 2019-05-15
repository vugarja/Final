$(document).ready(function () {
    var A=$("#mainMotivation table audio");
    
    $("#mainMotivation table audio").on("play",function(){
        $(this).addClass("playing");
        for (var i=0; i<A.length; i++) {
            if (!($(A[i]).hasClass("playing"))) {
                A[i].pause();
                A[i].currentTime=0;
            }
        }
        $(this).removeClass("playing");
    })
})