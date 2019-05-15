$(document).ready(function () {

    //---------scroll olarken headerin deyishmeyi----//
    $(window).scroll(function (e) {
        if ($(this).scrollTop() > 100) {
            $(".headerMain").addClass("scrolled");
        }
        else {
            $(".headerMain").removeClass("scrolled");
        }
    });
    //----------------------------------//

    // $(window).on('beforeunload', function() { //sehife yenilenerken basha qayitmaq
    //     $(window).scrollTop(0);
    // });

})