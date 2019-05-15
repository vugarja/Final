$(document).ready(function () {

    //----------------Form------------------//
    $('.iSearch').foxholder({
        placeholderDemo: 2
    });
    //----------------------------------//


    //-----------------Typed plugin-----------------//
    var typed = new Typed('#typed', {
        stringsElement: '#typed-strings',
        backSpeed: 20,
        typeSpeed: 75,
        loop: true,
        loopCount: Infinity
    });
    //----------------------------------//


    //----------------Select-option bolmeleri------------------//
    $(".iSelect select").click(function () { //metro ve rayonlarin sechilmesi
        if ($(this).val() == 1) {
            $(".metrolar").removeClass("d-none");
            if (!($(".rayonlar").hasClass("d-none"))) {
                $(".rayonlar").addClass("d-none")
            }

        }
        else if ($(this).val() == 2) {
            $(".rayonlar").removeClass("d-none");
            if (!($(".metrolar").hasClass("d-none"))) {
                $(".metrolar").addClass("d-none")
            }
        }
    })

    $("select.kombat").on('change', function () { //tekbetek doyush novleri
        if (this.value == 3) {
            $(".sport-type").removeClass("d-none");
        }
        else {
            if (!($(".sport-type").hasClass("d-none"))) {
                $(".sport-type").addClass("d-none");
            }
        }
    });
    //----------------------------------//


})