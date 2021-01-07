(function ($) {
"use strict";  
    
/*------------------------------------
	Sticky Menu 
--------------------------------------*/
 var windows = $(window);
    var stick = $(".header-sticky");
	windows.on('scroll',function() {    
		var scroll = windows.scrollTop();
		if (scroll < 5) {
			stick.removeClass("sticky");
		}else{
			stick.addClass("sticky");
		}
	});  
/*------------------------------------
	jQuery MeanMenu 
--------------------------------------*/
	$('.main-menu nav').meanmenu({
		meanScreenWidth: "767",
		meanMenuContainer: '.mobile-menu'
	});
    
    
    /* last  2 li child add class */
    $('ul.menu>li').slice(-2).addClass('last-elements');
/*------------------------------------
	Owl Carousel
--------------------------------------*/
    $('.slider-owl').owlCarousel({
        loop:true,
        nav:true,
        animateOut: 'fadeOut',
        animateIn: 'fadeIn',
        smartSpeed: 2500,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });

    $('.partner-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:3
            },
            1000:{
                items:5
            }
        }
    });  

    $('.testimonial-owl').owlCarousel({
        loop:true,
        nav:true,
        navText:['<i class="fa fa-angle-left"></i>','<i class="fa fa-angle-right"></i>'],
        responsive:{
            0:{
                items:1
            },
            768:{
                items:1
            },
            1000:{
                items:1
            }
        }
    });
/*------------------------------------
	Video Player
--------------------------------------*/
    $('.video-popup').magnificPopup({
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        zoom: {
            enabled: true,
        }
    });
    
    $('.image-popup').magnificPopup({
        type: 'image',
        gallery:{
            enabled:true
        }
    }); 
/*----------------------------
    Wow js active
------------------------------ */
    new WOW().init();
/*------------------------------------
	Scrollup
--------------------------------------*/
    $.scrollUp({
        scrollText: '<i class="fa fa-angle-up"></i>',
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    });
/*------------------------------------
	Nicescroll
--------------------------------------*/
     $('body').scrollspy({ 
            target: '.navbar-collapse',
            offset: 95
        });
$(".notice-left").niceScroll({
            cursorcolor: "#EC1C23",
            cursorborder: "0px solid #fff",
            autohidemode: false,
            
        });

})(jQuery);	


/*------------------------------------
	Search
--------------------------------------*/
$(document).ready(function () {
    $(document).on('keyup', '#search-input', function () {

        let searchInput = $(this).val().trim();
        $("#search-list li").remove();
        if (searchInput.length > 0) {

            $.ajax({
                url: "/Courses/Search?search=" + searchInput,
                type: "Get",
                success: function (res) {
                    $("#search-list").append(res);
                }
            });
        }
    })

    $('#search-list').on('click', 'li', function () {
        var click_text = $(this).text().split('|');
        $('#search-input').val($.trim(click_text[0]));
        $("#search-list").html('');
    });

})



//$(document).ready(function () {
//    $('#search-input').keyup(function () {
//        $('#search-list').html('');
//        $('#state').val('');
//        var searchField = $('#search-input').val();

//        $.ajax({
//                url: "/Courses/Search?search=" + searchInput,
//                type: "Get",
//                success: function (res) {
//                    $("#search-list").append(res);
//                }
//            });
//    });

//    $('#search-list').on('click', 'li', function () {
//        var click_text = $(this).text().split('|');
//        $('#search-input').val($.trim(click_text[0]));
//        $("#search-list").html('');
//    });
//});




//        //$.getJSON('data.json', function (data) {
//        //    $.each(data, function (key, value) {
//        //        if (value.name.search(expression) != -1 || value.location.search(expression) != -1) {
//        //            $('#search-list').append('<li class="list-group-item link-class"><img src="' + value.image + '" height="40" width="40" class="img-thumbnail" /> ' + value.name + ' | <span class="text-muted">' + value.location + '</span></li>');
//        //        }
//        //    });
//        //});

