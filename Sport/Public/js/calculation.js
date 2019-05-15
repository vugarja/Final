$(document).ready(function () {

    //---------------Hesablamalar bolmesi-------------------//
    var activity = 0;
    $("select.activity").on('change', function () { //aktivlik derecesi
        activity = Number(this.value);
    });

    $("#mainCalc .iCalc .sbm .iBtn").click(function (e) { //riyazi hesablamalar
        e.preventDefault();
        var weight = Number($("#mainCalc .iCalc #weight").val());
        var height = Number($("#mainCalc .iCalc #height").val());
        var old = Number($("#mainCalc .iCalc #old").val());
        var gender = Number($("#mainCalc .iCalc .gender input:checked").val());
        var sport = Number($("#mainCalc .iCalc .sport input:checked").val());
        var supp = Number($("#mainCalc .iCalc .supp input:checked").val());

        var active;
        if (activity == 1) {
            active = 1.2;
        }
        else if (activity == 2) {
            active = 1.375;
        }
        else if (activity == 3) {
            active = 1.55;
        }
        else if (activity == 4) {
            active = 1.725;
        }
        else if (activity == 5) {
            active = 1.9;
        }

        //male
        if (gender == 1) {
            var calori = ((10 * weight) + (6.25 * height) - (5 * old) + 5) * active;
            var meta = 66.5 + (13.75 * weight) + (5.03 * height) - (6.75 * old);
            var idealWeight = 50 + ((height - 152.4) / 2.54) * 2.3;
        }

        //famale
        else if (gender == 2) {
            var calori = ((10 * weight) + (6.25 * height) - (5 * old) - 161) * active;
            var meta = 655.1 + (9.56 * weight) + (1.85 * height) - (4.68 * old);
            var idealWeight = 45.5 + ((height - 152.4) / 2.54) * 2.3;

        }

        //water
        var date = new Date();
        var month = date.getMonth() + 1;

        var water = weight * 0.035;
        if (sport == 1) {
            water += 1;
        }
        if (supp == 1) {
            water += 1;
        }
        if (month > 5 && month < 9) {
            water += 1;
        }

        $(this).parents(".calculating").find(".meta .calc").text(Math.ceil(meta) + " kkal");
        $(this).parents(".calculating").find(".calori .calc").text(Math.ceil(calori) + " kkal");
        $(this).parents(".calculating").find(".water .calc").text((Math.round(water * 10)) / 10 + " litr");
        $(this).parents(".calculating").find(".weight .calc").text((Math.ceil(idealWeight * 10)) / 10 + " kq");
    })
    //----------------------------------//


    //---------------Form-------------------//
    $('.iCalc').foxholder({
        placeholderDemo: 7
    });
    //----------------------------------//
})