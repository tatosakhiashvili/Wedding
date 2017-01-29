var wedding = (function () {
	var initSeconds = 0;
	var initMinutes = 0;
	var initHours = 0;
	var initDays = 0;

	function countDownSeconds() {
		if (initSeconds == 0) { initSeconds = 60; countDownMinutes(); } initSeconds -= 1;

		$('.count-down-col.seconds .date-caption').html(formater(initSeconds));
	};

	function countDownMinutes() {
		if (initMinutes == 0) { initMinutes = 60; countDownHours(); } initMinutes -= 1;
		$('.count-down-col.minutes .date-caption').html(formater(initMinutes));
	};

	function countDownHours() {
		if (initHours == 0) { initHours = 24; countDownDays(); } initHours -= 1;
		$('.count-down-col.hours .date-caption').html(formater(initHours));
	};

	function countDownDays() {
		//if (initDays == 0) { initDays = 24; }
		initDays -= 1;
		$('.count-down-col.days .date-caption').html(formater(initDays));
	};

	function formater(value) {
		if (value.toString().length == 1) {
			return ('0' + value.toString());
		} else {
			return value.toString();
		}
	}

	return {

		initializeCountDown: function (seconds, minutes, hours, days) {
			initSeconds = seconds;
			initMinutes = minutes;
			initHours = hours;
			initDays = days;

			$('.count-down-col.seconds .date-caption').html(formater(initSeconds));
			$('.count-down-col.minutes .date-caption').html(formater(initMinutes));
			$('.count-down-col.hours .date-caption').html(formater(initHours));
			$('.count-down-col.days .date-caption').html(formater(initDays));

			setInterval(function () {
				countDownSeconds();
			}, 1000);
		},

		initPage: function () {
			$('.main-container').fadeIn();
		},

		showMenu: function () {
			console.log('Showing Menu');
		},

		closeMenu: function () {
			console.log('Closing Menu');
		}
	};
})();