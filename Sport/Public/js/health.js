$(document).ready(function () {

    //-----------------Kartlara hover ederken backgroundun deyishmesi-----------------//        
    $("#mainHealth .iTilt").hover(function () {
        $(this).parent().addClass("activeHover");
        $("body").addClass("bodyBg")
    }, function () {
        $(this).parent().removeClass("activeHover");
        $("body").removeClass("bodyBg")
    })
    //----------------------------------// 
    
})