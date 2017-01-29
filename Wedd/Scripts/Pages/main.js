var initSeconds = 0;
var initMinutes = 0;
var initHours = 0;
var initDays = 0;

function initializeCountDown(seconds, minutes, hours, days) {
	initSeconds = seconds;
	initMinutes = minutes;
	initHours = hours;
	initDays = days;

	$('.count-down-col.seconds').html(formater(initSeconds));
	$('.count-down-col.minutes').html(formater(initMinutes));
	$('.count-down-col.hours').html(formater(initHours));
	$('.count-down-col.days').html(formater(initDays));

	setInterval(function () {
		countDownSeconds();
	}, 1000);
}

function countDownSeconds() {
	if (initSeconds == 0) { initSeconds = 60; countDownMinutes(); } initSeconds -= 1;

	$('.count-down-col.seconds').html(formater(initSeconds));
};

function countDownMinutes() {
	if (initMinutes == 0) { initMinutes = 60; countDownHours(); } initMinutes -= 1;
	$('.count-down-col.minutes').html(formater(initMinutes));
};

function countDownHours() {
	if (initHours == 0) { initHours = 24; countDownDays(); } initHours -= 1;
	$('.count-down-col.hours').html(formater(initHours));
};

function countDownDays() {
	//if (initDays == 0) { initDays = 24; }
	initDays -= 1;
	$('.count-down-col.days').html(formater(initDays));
};

function formater(value) {
	if (value.toString().length == 1) {
		return ('0' + value.toString());
	} else {
		return value.toString();
	}
}

function showLoader() {
	$("#page-loader").show().animate({ opacity: 1 }, 100, function () { });
}

function hideLoader() {
	//$("#page-loader").animate({ opacity: 0 }, 1500, function () { });
	$("#page-loader").animate({ opacity: 0 }, {
		duration: 1500,
		complete: function () {
			$('#page-loader').hide();
		}
	});
}

function toggleMenu() {
	var $menu = $('.menu-container');
	if ($menu.css('right') == '0px') {
		closeMenu()
	} else {
		showMenu();
	}
}

function showMenu() {
	var $menu = $('.menu-container');
	var menuWidth = $menu.width();

	menuWidth += parseInt($menu.css('padding-left'));
	menuWidth += parseInt($menu.css('padding-right'));
	 
	$menu.css('right', menuWidth * -1).animate({
		right: 0
	}, {
		duration: 400
	});
}

function closeMenu() {
	var $menu = $('.menu-container');
	var menuWidth = $menu.width();

	menuWidth += parseInt($menu.css('padding-left'));
	menuWidth += parseInt($menu.css('padding-right'));

	$menu.animate({
		right: (menuWidth * -1)
	}, {
		duration: 400
	});
}