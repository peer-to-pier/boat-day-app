define([
'underscore',
'parse'
], function(_, Parse){

	var SeatRequestModel = Parse.Object.extend("SeatRequest", {

		defaults: {
			status: "pending",
			seats: null,
			card: null,
			boatday: null
		},

	});

	return SeatRequestModel;

});