$(document).ready(function () {

    //---------------Shekiller ucun plugin-------------------//
    $('.iPopup').magnificPopup({
        type: 'image',
        gallery: {
            enabled: true
        }
    });
    //----------------------------------//

    //----------------Promokod xeberdarliq------------------//
    var say = 0;
    $("header .iPromo .iBtn").click(function (e) {
        e.preventDefault();
        var name = $(this).parents(".iReg").find("#name").val();
        var surname = $(this).parents(".iReg").find("#surname").val();
        var promo = $(this).parents(".iReg").find("#promo").val();

        if (!name || !surname || !promo) {
            if (say == 0) {
                $(this).parent().before("<div class='alert alert-danger' role='alert' style='padding:10px; font-size:14px'>Bütün məlumatları daxil edin</div>")
                say++;
            }
        }
        else {
            $("header .iPromo .sign").append("<div class='alert alert-success' role='alert' style='padding:10px; font-size:14px'>Əməliyyat yerinə yetirildi</div>");
            $(this).parents(".sign").find("strong").remove();
            $(this).parents(".sign").find("form").remove();


            $("header .sign-in .fa-times").click(function () {
                location.reload();
            });
        }
    })
    //----------------------------------//


    //------------------Endirimden istifade etmek----------------//
    $("#moreInfo .sale .iBtn").click(function () {
        $("header .registration").removeClass("d-none");
        $(".registration .iPromo").removeClass("d-none");

        $("header .sign-in .fa-times").click(function () {
            if (!($(".iPromo").hasClass("d-none"))) {
                $(".iPromo").addClass("d-none");
            }

        })
    })
    //----------------------------------//

})