$(document).ready(function () {

        //-----------------Preloader-----------------//
        $('#loader').fadeOut('slow');
        //----------------------------------//


        //-------sehife yenilenerken headeri cari veziyyetde saxlamaq------//
        $(window).on('load', function () {
                $(window).scrollTop(0);
        });
        //----------------------------------//

        //---------------Kicik ekranlarda menu uchun-------------------//
        $("header .col-lg-9 .menuIcon").click(function () {
                $(this).toggleClass("menuOpen");
                if ($(window).scrollTop() < 100) {
                        $(".headerMain").toggleClass("scrolled")
                }

                $(".iMenu").toggleClass("menuActive");
                $("body").toggleClass("stopScrolling");

        })
        $(window).resize(function () { //pencerenin olcusu deyisende menu itmesi uchun
                if ($(window).width() > 992) {
                        $("header .col-lg-9 .menuIcon").removeClass("menuOpen");
                        $(".iMenu").removeClass("menuActive");
                        if ($(window).scrollTop() < 100 && $(".headerMain").hasClass("scrolled")) {
                                $(".headerMain").removeClass("scrolled")
                        }
                        if ($("body").hasClass("stopScrolling")) {
                                $("body").removeClass("stopScrolling")
                        }
                }
        });

        //----------------------------------//

        //----------------Menu drop-down------------------//
        $(".iMenu .fa-sort-down").click(function () {
                var A = $(this).next();
                $(this).toggleClass("fa-sort-up")
                if (!($(this).next().hasClass("downActive"))) {
                        $(this).next().addClass("downActive");
                }
                else {
                        $(this).next().removeClass("downActive");

                }

                $("header .col-lg-9 .menuIcon").click(function () {
                        for (var i = 0; i < A.length; i++) {
                                if (A.hasClass("downActive")) {
                                        A.removeClass("downActive");
                                }
                        }
                        $(".iMenu .fa-sort-up").removeClass("fa-sort-up");
                })

        })
        //----------------------------------//



        //-----------------Daxilolma-----------------//
        $(".sign .enter").click(function () { //daxilolma button'u
                $("header .registration").removeClass("d-none");
                $(".registration .iSigning").removeClass("d-none");
        })

        $(".sign-in .sign span.iBtn").click(function () { //qeydiyyat hissesine kechmek
                $(this).parent(".sign-in").addClass("d-none");
                $(".iRegistration").removeClass("d-none");
        })

        $("header .sign-in .fa-times").click(function () { //dialoqu baglamaq
                if (!($(".iSigning").hasClass("d-none"))) {
                        $(".iSigning").addClass("d-none");
                }
                if (!($(".iRegistration").hasClass("d-none"))) {
                        $(".iRegistration").addClass("d-none");
                }
                $(".registration").addClass("d-none");
        })

        $('.iReg').foxholder({ //form
                placeholderDemo: 11
        });
        //----------------------------------//



        //-----------------Daxil olma xeberdarliqlari-----------------//
        var say = 0;
        $("header .iSigning .iReg .iBtn").click(function (e) { //alert elave etmek
                e.preventDefault();
                if ((!($(this).parents(".iReg").find("#mail").val())) || (!($(this).parents(".iReg").find("#pass").val()))) {
                        if (say == 0) {
                                $(this).parent().before("<div class='alert alert-danger' role='alert' style='padding:10px; font-size:14px'>E-poçt ünvanı və ya şifrə yanlışdır</div>")
                                say++;
                        }
                }
                else {
                        if (!($(".iSigning").hasClass("d-none"))) {
                                $(".iSigning").addClass("d-none");
                        }
                        $(".registration").addClass("d-none");

                        $("header .container li.sign").addClass("d-none");
                        $("header .container li.profile").removeClass("d-none");
                        $(".iMenu li.sign").addClass("d-none");
                        $(".iMenu li.profile").removeClass("d-none");
                        say = 0;
                }
        })
        $("header .registration .fa-times").click(function () { //alerti silmek
                if ($("header .registration .alert")) {
                        $("header .registration .alert").remove();
                        say = 0;
                }
        })
        //-------------------------------------------------//


        var say2 = 0;
        //------------------------Shifreni unutmusuz?-------------------------//
        $("header .iSigning .iReg .remember").click(function () { //daxilolmaqdan kecid
                $(this).parents(".iSigning").addClass("d-none");
                $(this).parents(".registration").find(".iRemember").removeClass("d-none");

        })
        $("header .iRemember .iReg .iBtn").click(function (e) { //maile shifreni gondermek
                e.preventDefault();
                if ((!($(this).parents(".iReg").find("#mail").val()))) {
                        if (say2 == 0) {
                                $(this).parent().before("<div class='alert alert-danger' role='alert' style='padding:10px; font-size:14px'>E-poçt ünvanı yanlışdır</div>")
                                say2++;
                        }
                }
                else {
                        $("header .iRemember .sign").empty();
                        $("header .iRemember .sign").append("<i class='fas fa-times'></i>");
                        $("header .iRemember .sign").append("<div class='alert alert-success' role='alert' style='padding:10px; font-size:14px'>Şifrə E-poçt ünvanınıza göndərildi</div>");
                        $("header .iRemember .sign .fa-times").click(function () {
                                location.reload();
                        })
                }
        })
        $("header .registration .fa-times").click(function () { //alerti silmek
                if ($("header .registration .alert")) {
                        $("header .registration .alert").remove();
                        say2 = 0;
                }
        })
        //-------------------------------------------------//



        //-----------------Qeydiyyat xeberdarliqlari-----------------//

        //Dogum tarixine ancaq reqem daxil etmek
        // $("header .iRegistration .iReg #day").keypress(function (e) { //gun
        //         if ((e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57))||$(this).val().length>1) {
        //                 return false;
        //         }
        // });
        // $("header .iRegistration .iReg #month").keypress(function (e) { //ay
        //         if ((e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57))||$(this).val().length>1) {
        //                 return false;
        //         }
        // });
        // $("header .iRegistration .iReg #year").keypress(function (e) { //il
        //         if ((e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57))||$(this).val().length>3) {
        //                 return false;
        //         }
        // });

        //formlarin duzgun doldurulmasi
        var say3 = 0;
        $("header .iRegistration .iReg .iBtn").click(function (e) {
                e.preventDefault();
                var name = $(this).parents(".iReg").find("#name").val();
                var sur = $(this).parents(".iReg").find("#surname").val();
                var mail = $(this).parents(".iReg").find("#mail").val();
                var pass = $(this).parents(".iReg").find("#pass").val();
                var pass2 = $(this).parents(".iReg").find("#pass2").val();
                // var day = $(this).parents(".iReg").find("#day").val();
                // var month = $(this).parents(".iReg").find("#month").val();
                // var year = $(this).parents(".iReg").find("#year").val();
                var alert;
                if (!name || !sur || !mail || !pass || !pass2) {
                        alert = "Məlumatları tam doldurun";
                        say++;
                }
                else {
                        say3 = 0;
                        if (pass != pass2) {
                                say3++;
                                alert = "Şifrəni düzgün daxil edin";
                        }
                        else {
                                say3 = 0;
                                // if (day>31||day<1||month>12||month<1||year>2018||year<1900) {
                                //         say++;
                                //         alert="Doğum tarixini düzgün daxil edin"
                                // }
                                // else if (day==31&&(month==2||month==4||month==6||month==9||month==11)) {
                                //         say++;
                                //         alert="Doğum tarixini düzgün daxil edin"
                                // }
                                // else if ((day==30&&month==2)||(year%4!=0&&month==2)) {
                                //         say++;
                                //         alert="Doğum tarixini düzgün daxil edin"
                                // }
                                // else {
                                //         say=0;
                                // }
                        }
                }

                if (say3 == 0) {
                        $("header .registration .iRegistration .sign").append("<div class='alert alert-success' role='alert' style='padding:10px; font-size:14px'>Siz qeydiyyatdan keçdiniz</div>");
                        $(this).parents("form").remove();

                        $("header .sign-in .fa-times").click(function () {
                                location.reload();
                        });
                }
                else {
                        if (($(this).parents().eq(1).find(".alert-danger").length > 0)) {
                                $(this).parents().eq(1).find(".alert-danger").text(alert);
                        }
                        else {
                                $(this).parent().before("<div class='alert alert-danger' role='alert' style='padding:10px; font-size:14px'>" + alert + "</div>")

                        }
                }

        })

        //-------------------------------------------------//


        //----------------Istifadechi melumati------------------//       
        $(document).click(function (e) { //sehifeye klikleyende melumatin baglanmasi
                if (!$(e.target).closest("header .userDrop .fas").length && (!($("header .userDrop .userDown").hasClass("d-none")))) {
                        $("header .userDrop .userDown").addClass("d-none");
                }
        });

        $("header .userDrop .fas").click(function () { //icona klikleyende melumatin achilmasi
                if ($("header .userDrop .userDown").hasClass("d-none")) {
                        $("header .userDrop .userDown").removeClass("d-none");
                }
                else {
                        $("header .userDrop .userDown").addClass("d-none");
                }
        })
        //----------------------------------//   

})