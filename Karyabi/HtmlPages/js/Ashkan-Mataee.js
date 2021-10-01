$(document).ready(function() {


    $(".title").hover(function(){
		$(this).addClass("title-hover")},
		function(){
		$(this).removeClass("title-hover");
	});


    $(".content,.navbar").hover(function(){
		$(this).children().children(".title").addClass("title-hover");
		},
		function(){
		$(this).children().children(".title").removeClass("title-hover");
	});
	
	
});

//Design By Ashkan Mataee | Powered By اسکریپت.com