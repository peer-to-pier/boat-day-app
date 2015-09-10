define([
'models/ProfileModel',
'views/BaseView',
'text!templates/SignInTemplate.html'
], function(ProfileModel, BaseView, SignInTemplate){
	var SignInView = BaseView.extend({

		className: 'screen-sign-in',

		template: _.template(SignInTemplate),

		events: {
			"click .icon.back": "showSignIn",
			"click button.create-account": "showSignUp",
			
			"click button.sign-in" : "signIn",
			"click button.sign-up" : "signUp",
			"click button.facebook" : "signInFacebook",
		},

		render: function() {

			BaseView.prototype.render.call(this);

			this.$el.find('.block-sign-in').show();

			return this;
		},

		showSignIn: function() {

			this.$el.find('.block-sign-up').hide();
			this.$el.find('.block-sign-in').show();

		},

		showSignUp: function() {

			this.$el.find('.block-sign-up').show();
			this.$el.find('.block-sign-in').hide();
			
		},

		signIn: function(event) {

			event.preventDefault();

			var self = this;

			if( self.loading('.sign-in') ) {
				console.log('abort');
				return ;
			}

			if(this._in('email').val() == '') {
				self.fieldError("email", "Oops, you missed one");
				self.loading();
				return;
			}

			if(this._in('password').val() == '') {
				self.fieldError("password", "Oops, you missed one");
				self.loading();
				return;
			}

			Parse.User.logIn(this._in('email').val(), this._in('password').val()).then(function() {

				self.loading();

				$(document).trigger('loadProfile', function() {
					Parse.history.navigate('boatdays', true);
				});

			}, function(error) {

				self.loading();

				switch(error.code) {
					case 101: self._error("Invalid email/password"); break;
					default: self._error("An error occured, please try later"); break;
				}
			});

		},

		signUp: function(event) {

			event.preventDefault();

			var self = this;

			if( self.loading('.sign-up') ) {
				console.log('abort');
				return ;
			}

			if(this._in('signUpEmail').val() == "") {
				self.fieldError('signUpEmail', "Oops, you missed one");
				self.loading();
				return; 
			}

			if(this._in('signUpPassword').val() == "") {
				self.fieldError('signUpPassword', "Oops, you missed one");
				self.loading();
				return; 
			}

			new Parse.User().signUp({
				email: this._in('signUpEmail').val(), 
				username: this._in('signUpEmail').val(), 
				password: this._in('signUpPassword').val(), 
				type: "guest", 
				// ToDo : Bug fix, user is not saved in profile
				profile: new ProfileModel({ user: Parse.User.current() })
			}).then(signUpSuccess = function() {

				Parse.history.navigate('boatdays', true);

			}, function( error ) {

				self.loading();

				switch(error.code) {
					case 125: 
						self._error("Please provide a valid email address.");
						break;
					case 202: 
						self._error("This email is already taken");
						break;
					default:
						self._error("An error occured, please try again.");
						break;
				}

			});
		},

		signInFacebook: function() {

			var self = this;


			if( self.loading('.facebook') ) {
				console.log('abort');
				return ;
			}
			
			var fbLoginSuccess = function(userData) {

				if (!userData.authResponse){
					transferError("Cannot find the authResponse");
					return;
				}

				var authData = {
					id: String(userData.authResponse.userID),
					access_token: userData.authResponse.accessToken,
					expiration_date: new Date(new Date().getTime() + userData.authResponse.expiresIn * 1000).toISOString()
				};

				fbLogged.resolve(authData);
				fbLoginSuccess = null;
			};

			var transferFbUserToParse = function (authData) {
				console.log("** Transfer to parse");
				return Parse.FacebookUtils.logIn(authData);
			};

			var transferSuccess = function(user) {
				console.log("** Transfer success");
				self.handleSignIn("facebook", user);
			};

			var transferError = function(error) {
				console.log("** Login error:");
				console.log(error);
				// Sometimes while a crash, the user stays log out and it 
				// may trigger this error
				// The best workarround  is to sign him out properly.
				Parse.history.navigate('sign-out', true);
			};

			var fbLogged = new Parse.Promise();

			facebookConnectPlugin.login(["public_profile", "email", "user_about_me", "user_birthday", "user_friends"], fbLoginSuccess, transferError);

			fbLogged.then(transferFbUserToParse, transferError).then(transferSuccess, transferError);
			
		},

		handleSignIn: function(type, user) {
			
			var self = this;

			if( user.get("profile") ) {
				self.updateUserProfileFacebook(user, function() {
					$(document).trigger('loadProfile', function() {
						Parse.history.navigate('boatdays', true);
					});
				});
			} else {
				console.log('redirect to createProfile');
				switch(type) {
					case "facebook":
						self.createUserProfileFacebook(user);
						break;
					case "twitter":
						self.createUserProfileTwitter(user);
						break;
					case "email":
						self.createUserProfileEmail(user);	
						break;
				}
				
			}
		},

		createUserProfileEmail: function() {

		},

		updateUserProfileFacebook: function(user, cb) {

			var self = this;

			var handleErrors = function(error) {
				self.loading();
				self._error("Oops... something wrong happen. Please, try later");
				Parse.history.navigate('sign-out', true);
			};

			facebookConnectPlugin.api('/me?fields=email,first_name,last_name,gender,birthday,picture,bio', null, function(me) {
				console.log(me);
				user.save({ 
					email: me.email,
				}).then(cb, handleErrors);
			}, handleErrors);

		},

		createUserProfileFacebook: function(user) {

			var self = this;

			var handleErrors = function(error) {

				console.log('** create User Profile error:');
				console.log(error);
				if(error.code == 209) {
					// It can happen that the user is logged in 
					// and once we delete him from parse without a proper 
					// logout it stays blocked on the first page without any action possible or button displayed
					// To prevent that we do a natural logout
					// It nust never happen but we never now
					Parse.history.navigate('sign-out', true);
				}

				self.loading();
				self._error("Oops... something wrong happen. Please, try later");

			};

			var userUpdated = function() {

				$(document).trigger('loadProfile', function() {
					Parse.history.navigate('boatdays', true);
				});

			};

			var facebookApiSuccess = function(me) {
				console.log('** FB Api success:');
				console.log(me);

				var updateUser = function( profile ) {
					user.save({ 
						email: me.email,
						profile: profile,
						type: "guest"
					}).then(userUpdated, handleErrors);
				};

				if( me.birthday ) {
					var ds = me.birthday.split('/');	
				}

				var profile = new ProfileModel({
					firstName: me.first_name ? me.first_name : null,
					lastName: me.last_name ? me.last_name : null,
					gender: me.gender ? me.gender : null,
					birthday: me.birthday ? new Date(ds[2], ds[0]-1, ds[1]) : null,
					about: me.bio ? me.bio : null,
					user: Parse.User.current()
				});

				profile.save().then(updateUser, handleErrors);

			};

			facebookConnectPlugin.api('/me?fields=email,first_name,last_name,gender,birthday,picture,bio', null, facebookApiSuccess, handleErrors);

		}

	});
	return SignInView;
});
