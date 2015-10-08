@font-face {
  font-family: museo;
  src: url(../fonts/Museo700-Regular.ttf);
}
* {
  /* make transparent link selection, adjust last value opacity 0 to 1.0 */
  -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
}
body {
  -webkit-touch-callout: none;
  -webkit-text-size-adjust: none;
  -webkit-user-select: none;
  background: url(../resources/index-loading.png) center center no-repeat;
  background-size: cover;
  font-family: Avenir, "Helvetica Neue", Helvetica, sans-serif;
}
.clip-to-bottom {
  position: fixed;
  bottom: 0px;
  left: 0px;
  right: 0px;
}
.text-left {
  text-align: left;
}
.text-center {
  text-align: center;
}
.text-right {
  text-align: right;
}
header.bar.bar-nav,
div.content .bar-header-secondary {
  height: 55px !important;
  -webkit-transform: translateZ(0);
  -webkit-box-shadow: none;
  border-bottom: none;
  background: -webkit-linear-gradient(45deg, #0ab8c8, #13a7bf);
}
header.bar.bar-nav a.icon,
header.bar.bar-nav button.btn-nav {
  margin-top: 16px;
  color: white;
}
header.bar.bar-nav a.icon:after {
  content: "";
  position: absolute;
  top: 50%;
  left: 50%;
  width: 60px;
  height: 60px;
  margin-top: -30px;
  margin-left: -30px;
  background: transparent;
}
header.bar.bar-nav h1 {
  color: white;
  font-family: Avenir;
  font-size: 10.24pt;
  font-weight: 400;
  line-height: 10.24pt;
  margin-top: 28px;
  text-transform: uppercase;
  left: 50px;
  right: 50px;
  width: auto;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}
.bar-nav ~ .content {
  padding-top: 55px;
}
.bar-header-secondary ~ .content {
  padding-top: 120px;
}
div.content {
  background: white;
}
.content-padded {
  padding: 5px;
}
div.content h1,
div.content h2,
div.content h3,
div.content h4,
div.content h5,
div.content h6 {
  color: #546e7a;
  text-align: center;
  font-weight: 200;
  margin-top: 30px;
  margin-bottom: 20px;
}
div.content h1 {
  font-size: 1em;
}
div.content h2 {
  font-size: 1em;
}
div.content h3 {
  font-size: 1em;
}
div.content h4 {
  font-size: 1em;
}
div.content h5 {
  font-size: 1em;
}
div.content h6 {
  font-size: 1em;
}
div.content p,
div.content td,
div.content sup,
div.content sub {
  color: #546e7a;
}
div.content p.secondary {
  color: #b2c0cc;
}
.btn {
  background-color: #f9fbfb;
  color: #13a7bf;
  border: 1px solid #e1e6ea;
  border-radius: 5px;
  line-height: 35px;
  padding: 5px;
  font-weight: 500;
  font-size: 0.8em;
}
.btn-primary {
  background-color: white;
  color: #13a7bf;
  border: 2px solid #13a7bf;
}
.btn-action {
  background-color: #f5b019;
  color: white;
  border: 1px solid #f5b019;
}
.btn:active,
.btn.active {
  background-color: #e1e6ea;
  color: white;
  border-color: #e1e6ea;
}
.btn-primary:active,
.btn-primary.active {
  background-color: #13a7bf;
  color: white;
  border-color: #13a7bf;
}
.btn-action:active,
.btn-action.active {
  background-color: #f5b019;
  color: white;
  border-color: #f5b019;
}
.btn-group button {
  width: 50%;
  display: inline-block;
}
.btn-group button:first-child {
  border-bottom-right-radius: 0px;
  border-top-right-radius: 0px;
  float: left;
}
.btn-group button:last-child {
  border-bottom-left-radius: 0px;
  border-top-left-radius: 0px;
}
input[type=color],
input[type=date],
input[type=datetime-local],
input[type=datetime],
input[type=email],
input[type=month],
input[type=number],
input[type=password],
input[type=search],
input[type=tel],
input[type=text],
input[type=time],
input[type=url],
input[type=week],
select,
textarea {
  padding: 10px 15px;
  color: #546e7a;
  border: 1px solid #e1e6ea;
  background: white;
  border-radius: 5px;
  font-weight: 400;
  font-size: 0.8em;
  line-height: 30px;
  height: 52px;
  /* height + padding + border */
}
select {
  font-weight: 400 !important;
  -webkit-box-shadow: none;
  background: url(../resources/select-arrows.png) no-repeat center right 0px white;
}
.field-flag-error {
  border-color: #f86335 !important;
}
textarea {
  padding: 10px;
  height: auto;
}
label {
  font-weight: 500;
  font-size: 0.7em;
  color: #546e7a;
}
.clear {
  display: block;
  clear: both;
}
.profile-picture {
  background: center center no-repeat white;
  background-size: cover;
  background-image: url(../resources/profile-picture-placeholder.png);
  height: 60px;
  width: 60px;
  border-radius: 70px;
  display: block;
}
.modal {
  z-index: 11;
}
.modal header.bar.bar-nav {
  z-index: 21;
}
video {
  max-height: 100%;
  position: absolute;
  top: 0px;
  left: 0px;
}
.logo-placeholder {
  display: block;
  max-width: 120px;
  margin: 20px auto;
  margin-top: 120px;
}
a {
  color: #13a7bf;
  font-weight: 500;
}
.overlay {
  background: rgba(74, 79, 84, 0.9);
  position: absolute;
  top: 0px;
  left: 0px;
  bottom: 0px;
  right: 0px;
  -webkit-transform: translate3d(0, 0, 1px);
  display: none;
}
.overlay.active {
  display: block;
}
.overlay .box {
  margin: 0px 25px;
  background: white;
  border-radius: 20px;
  position: relative;
}
.overlay .inner {
  padding: 25px;
}
.overlay h1 {
  font-size: 1em;
  text-align: center;
  font-weight: 500;
  color: #546e7a ;
  margin: 15px 0px 30px 0px;
  line-height: normal;
}
.overlay label {
  margin-top: 15px !important;
  font-weight: 700 !important;
}
.overlay .inner > *:last-child {
  margin-bottom: 0px;
}
.overlay .overlay-close {
  color: #24acc2;
  font-weight: 900;
  top: 15px;
  right: 15px;
  position: absolute;
}
.segmented-control-multi {
  position: relative;
  display: table;
  overflow: hidden;
  font-size: 12px;
  font-weight: 400;
  background-color: white;
  border: 1px solid #13a7bf;
  border-radius: 3px;
}
.segmented-control-multi .control-item {
  display: table-cell;
  width: 1%;
  padding-top: 6px;
  padding-bottom: 7px;
  overflow: hidden;
  line-height: 1;
  color: #13a7bf;
  text-align: center;
  text-overflow: ellipsis;
  white-space: nowrap;
  border-left: 1px solid #13a7bf;
}
.segmented-control-multi .control-item:first-child {
  border-left-width: 0;
}
.segmented-control-multi .control-item:active {
  background-color: #13a7bf;
  color: white;
}
.segmented-control-multi .control-item.active {
  background-color: #13a7bf;
  color: white;
}
.hidden-content {
  position: absolute;
  width: 0px;
  overflow: hidden;
}
.hidden-content * {
  opacity: 0;
}
.bar-header-secondary {
  top: 55px;
  height: 55px;
  border-bottom: 2px solid #0B0B0C;
  overflow: hidden;
  background: #3B3D3C;
  white-space: nowrap;
  padding: 0px;
}
.bar-header-secondary.filter-categories {
  font-size: 0px;
  text-align: center;
}
.bar-header-secondary.filter-categories a.control-item {
  color: #B0B0B0;
  font-size: 10px;
  font-weight: 500;
  text-transform: uppercase;
  line-height: 60px;
  padding: 0px 10px;
  display: inline-block;
  margin: 0px;
}
.bar-header-secondary.filter-categories a.active,
.bar-header-secondary.filter-categories a:active {
  color: white;
}
.bar-header-secondary.filter-categories span.control-item-handler {
  background: #F9FBFB;
  border-top: 1px solid #CCCECE;
  border-bottom: 1px solid #8B8C8D;
  position: absolute;
  bottom: 0px;
  height: 1px;
}
.snap-drawer {
  background: transparent;
  width: 266px;
}
.snap-drawer.snap-drawer-left .top {
  height: 190px;
  background: #2b3336;
  padding-top: 40px;
  border-right: 1px solid #252b2e;
}
.snap-drawer.snap-drawer-left .profile-picture {
  width: 100px;
  height: 100px;
  border-radius: 120px;
  background: center center no-repeat;
  background-size: cover;
  margin: 0px auto;
}
.snap-drawer.snap-drawer-left .name {
  color: white;
  text-align: center;
  font-weight: 200;
  margin-top: 10px;
  opacity: 0.4;
}
.snap-drawer.snap-drawer-left .links {
  position: absolute;
  top: 190px;
  bottom: 0px;
  background: -webkit-linear-gradient(#13a7bf, #0ab8c8);
  text-align: center;
  border-right: 1px solid #0b99a8;
}
.snap-drawer.snap-drawer-left .links .inner {
  background: rgba(255, 255, 255, 0.15);
  padding-bottom: 20px;
}
.snap-drawer.snap-drawer-left .links a {
  width: 50%;
  float: left;
  font-size: 0.6em;
  font-weight: 200;
  padding-top: 20px;
  position: relative;
}
.snap-drawer.snap-drawer-left .links a .total-notifications {
  position: absolute;
  top: 15px;
  left: 50%;
  margin-left: 10px;
  dsplay: block;
  background: white;
  width: 25px;
  height: 25px;
  border-radius: 25px;
  line-height: 21px;
  color: #0ab8c8;
  font-size: 1.2em;
  font-weight: 500;
  border: 2px solid #0ab8c8;
}
.snap-drawer.snap-drawer-left .links a img {
  display: block;
  margin: 0px auto 5px auto;
  max-width: 60px;
}
.snap-drawer.snap-drawer-left a {
  color: white;
}
.snap-drawer.snap-drawer-left .clip-to-bottom {
  right: auto;
  width: 266px;
}
.snap-drawer.snap-drawer-left .clip-to-bottom a {
  display: block;
  width: 100%;
  height: 40px;
  line-height: 40px;
  font-size: 0.7em;
  text-align: center;
  margin-bottom: 5px;
}
.snap-drawer.snap-drawer-left .clip-to-bottom a {
  border-top: 1px solid #51cddc;
}
.snap-drawer.snap-drawer-left .clip-to-bottom a:first-child {
  border-top: none;
}
div.content button.btn.loading,
div.content a.btn.loading {
  color: transparent !important;
}
div.content button.btn.loading:after,
div.content a.btn.loading:after {
  content: "";
  z-index: 100;
  position: absolute;
  top: 50%;
  margin-top: -15px;
  left: 50%;
  margin-left: -15px;
  width: 30px;
  height: 30px;
  background: url(../resources/logo-30.png) center center no-repeat;
  -webkit-animation: "pulse1" 0.8s ease-in-out alternate infinite;
  opacity: 1;
}
div.content button.btn.btn-action.loading:after,
div.content button.btn.facebook.loading:after,
div.content a.btn.facebook.loading:after,
div.content a.btn.btn-action.loading:after {
  background: url(../resources/logo-30-white.png) center center no-repeat;
}
/*
div.loading {
	width: 100%;
	height: 100%;
	position: absolute;
	background: url(../resources/logo-60.png) center center no-repeat;
	-webkit-animation: "pulse1" 0.8s ease-in-out alternate infinite;
	opacity: 1;
}
*/
@-webkit-keyframes "pulse1" {
  0% {
    -webkit-transform: scale(1.1);
    -webkit-filter: blur(4px);
  }
  50% {
    -webkit-transform: scale(0.8);
    -webkit-filter: blur(0px);
  }
  100% {
    -webkit-transform: scale(1);
    -webkit-filter: blur(2px);
  }
}
.message {
  position: fixed;
  top: 0px;
  left: 0px;
  width: 100%;
  color: white;
  padding: 10px;
  padding-top: 20px;
  z-index: 10000;
  font-size: 0.8em;
  -webkit-animation-name: fadeOut;
  -webkit-animation-duration: 3s;
  -webkit-animation-timing-function: linear;
  -webkit-animation-fill-mode: forwards;
}
@-webkit-keyframes fadeOut {
  0% {
    opacity: 0;
    -webkit-transform: translateY(-30px);
  }
  10% {
    opacity: 1;
    -webkit-transform: translateY(0px);
  }
  90% {
    opacity: 1;
    -webkit-transform: translateY(0px);
  }
  99% {
    opacity: 0;
    -webkit-transform: translateY(-30px);
  }
  100% {
    opacity: 0;
  }
}
.message.message-info {
  background: #13a7bf;
}
.message.message-error {
  background: #d9534f;
}
.message.message .icon {
  font-size: 1.2em;
  padding: 0px 0px 0px 0px;
}
.screen-about-us .version {
  font-size: 1em;
  font-weight: 400;
  margin-bottom: 0px;
  margin-top: 25px;
}
.screen-about-us .date {
  font-size: 0.7em;
  color: #b2c0cc;
  font-weight: 700;
}
.screen-about-us img.logo {
  max-width: 120px;
  margin-top: 25px;
  margin-bottom: 25px;
}
.screen-about-us p.description {
  margin-bottom: 15px;
}
.screen-about-us textarea {
  margin-bottom: 5px;
}
.screen-about-us .social,
.screen-about-us .website {
  margin-top: 50px;
}
.screen-about-us .social p,
.screen-about-us .website p {
  margin-bottom: 15px;
}
.screen-about-us .social a {
  width: 33%;
  float: left;
  font-size: 0.7em;
  color: #b2c0cc;
  font-weight: 400;
  display: block;
}
.screen-about-us .social img {
  display: block;
  margin: auto;
  max-width: 60px;
}
.screen-profile .content .grey-area {
  background: #f9fbfb;
  border-bottom: 2px solid rgba(29, 29, 28, 0.05);
}
.screen-profile .content .header {
  text-align: center;
  padding: 49px 0px 37px 0px;
}
.screen-profile .content .header .host-picture,
.screen-profile .content .header .guest-picture {
  width: 78px;
  height: 78px;
  border-radius: 5pt;
  display: inline-block;
  background-size: cover;
}
.screen-profile .content .header .guest-picture {
  border-radius: 78px;
}
.screen-profile .content .header h1 {
  color: #546e7a;
  font-size: 17pt;
  font-weight: 400;
  line-height: 23pt;
  margin: 19px 0px 0px 0px;
  padding: 0px;
}
.screen-profile .content .header h2 {
  color: rgba(84, 110, 122, 0.45);
  font-size: 9pt;
  font-weight: 400;
  line-height: 12pt;
  margin: 0px;
  padding: 0px;
}
.screen-profile .content .header p.about {
  color: rgba(84, 110, 122, 0.79);
  font-size: 11pt;
  font-weight: 300;
  font-style: italic;
  line-height: 15pt;
  margin: 16px 45px 3px 45px;
  padding: 0px;
}
.screen-profile .content .header .certifications p {
  color: #546e7a;
  font-size: 9pt;
  font-weight: 400;
  line-height: 12pt;
  margin: 1px 0px;
  padding: 0px;
  display: inline-block;
  position: relative;
}
.screen-profile .content .header .certifications p:first-child {
  margin-top: 15px;
}
.screen-profile .content .header .certifications p:after {
  content: "";
  width: 23pt;
  height: 23pt;
  position: absolute;
  top: -5.5pt;
  left: -23pt;
  background: url(../resources/check-grey.png) center center no-repeat;
}
.screen-profile .content h3 {
  color: #546e7a;
  font-size: 9pt;
  font-weight: 400;
  line-height: 14pt;
  margin: 0px;
  padding: 4px 14px 6px 14px;
  background: #dfeff1;
  display: inline-block;
  border-radius: 0px 0px 2pt 2pt;
}
.screen-profile .content .boatdays {
  text-align: center;
}
.screen-profile .content .boats {
  text-align: center;
}
.screen-profile .content .boats .list .boat {
  margin: 12px 37px 0px 37px;
  text-align: left;
  border: 1pt solid #e4e9eb;
  border-bottom-width: 2pt;
  border-radius: 2pt;
}
.screen-profile .content .boats .list .boat:first-child {
  margin-top: 31px;
}
.screen-profile .content .boats .list .boat:last-child {
  margin-bottom: 39px;
}
.screen-profile .content .boats .list .boat .boat-image {
  width: 25px;
  height: 25px;
  border-radius: 2pt;
  background-size: cover;
  display: inline-block;
  margin: 12px;
  vertical-align: middle;
}
.screen-profile .content .boats .list .boat p {
  color: #546e7a;
  font-size: 12pt;
  font-weight: 400;
  line-height: 13pt;
  display: inline-block;
  vertical-align: middle;
  margin: 0px;
}
.screen-profile .content .reviews {
  padding: 5px 0px;
  border-bottom: 2px solid rgba(29, 29, 28, 0.05);
}
.screen-profile .content .reviews p.no-data {
  color: rgba(84, 110, 122, 0.35);
  font-size: 11pt;
  font-weight: 400;
  line-height: 15pt;
  margin: 22px 0px;
  padding: 0px;
}
.screen-profile .content .reviews div.review {
  margin: 21px 25px 0px 25px;
  padding: 0px 0px 30px 0px;
  border-bottom: 1px solid rgba(29, 29, 36, 0.05);
}
.screen-profile .content .reviews div.review:last-child {
  border-bottom: none;
}
.screen-profile .content .reviews div.review .heading {
  font-size: 0pt;
}
.screen-profile .content .reviews div.review .host-picture,
.screen-profile .content .reviews div.review .guest-picture {
  width: 26pt;
  height: 26pt;
  border-radius: 26pt;
  background-size: cover;
  vertical-align: middle;
  display: inline-block;
}
.screen-profile .content .reviews div.review .host-picture {
  border-radius: 2.13pt;
}
.screen-profile .content .reviews div.review h4 {
  color: #11abc1;
  font-size: 10.67pt;
  font-weight: 500;
  line-height: 15pt;
  margin: 0px;
  margin-left: 8px;
  padding: 0px;
  vertical-align: middle;
  display: inline-block;
  position: relative;
}
.screen-profile .content .reviews div.review h4:after {
  content: "";
  width: 3pt;
  height: 3pt;
  border-radius: 3pt;
  position: absolute;
  right: -8pt;
  top: 6pt;
  background: #546e7a;
}
.screen-profile .content .reviews div.review .date {
  color: #b1bfcc;
  font-size: 9.53pt;
  font-weight: 400;
  line-height: 12pt;
  margin: 7pt 0px;
  padding: 0px;
  display: inline-block;
  float: right;
}
.screen-profile .content .reviews div.review .rating {
  width: 60px;
  margin: 0px;
  margin-left: 13pt;
  padding: 0px;
  line-height: 12pt;
  vertical-align: middle;
  display: inline-block;
}
.screen-profile .content .reviews div.review .rating .rating-full {
  width: 12px;
  height: 12px;
  float: left;
  margin: 0px;
  padding: 0px;
  background: url(../resources/rating-full.png) center center no-repeat;
}
.screen-profile .content .reviews div.review .rating .rating-empty {
  width: 12px;
  height: 12px;
  float: left;
  margin: 0px;
  padding: 0px;
  background: url(../resources/rating-empty.png) center center no-repeat;
}
.screen-profile .content .reviews div.review p.review {
  color: #546e7a;
  font-size: 11.52pt;
  font-weight: 400;
  line-height: 16pt;
  margin: 11px 0px 10px 0px;
  padding: 0px;
}
.screen-profile .content .reviews div.review p.boatday {
  color: #b1bfcc;
  font-size: 9.39pt;
  font-weight: 400;
  line-height: 12pt;
  margin: 0px;
  padding: 0px;
}
.screen-profile .content .boatdays .boatday-card {
  border: 1px solid red;
  border-radius: 4.27pt;
  overflow: hidden;
  border: 1px solid #e4e9eb;
  border-bottom-width: 2px;
  margin: 0px 66px;
}
.screen-profile .content .boatdays .boatday-card .boatday-image {
  height: 144px;
  background-size: cover;
}
.screen-profile .content .boatdays .boatday-card .details {
  background: white;
  padding: 20px 13px 16px 13px;
}
.screen-profile .content .boatdays .boatday-card .details p {
  color: #546e7a;
  font-size: 11.95pt;
  font-weight: 400;
  line-height: 16pt;
  margin: 0px;
  padding: 0px;
}
.screen-profile .content .boatdays .swiper-container {
  width: 100%;
  height: 100%;
  padding: 29px 0px 54px 0px;
}
.screen-profile .content .boatdays .swiper-button-disabled {
  opacity: 0;
}
.screen-profile .content .boatdays .swiper-button-prev {
  left: 23px;
}
.screen-profile .content .boatdays .swiper-button-next {
  right: 23px;
}
.screen-profile .content .boatdays .swiper-button-next,
.screen-profile .content .boatdays .swiper-button-prev {
  background: none;
  line-height: 22px;
  width: 20px;
  height: 20px;
  border: 1px solid #546e7a;
  border-radius: 20px;
  font-size: 8px;
  text-align: center;
  margin-top: -10px;
}
.screen-profile .content .boatdays .swiper-button-prev:after,
.screen-profile .content .boatdays .swiper-button-next:after {
  content: "";
  width: 40px;
  height: 60px;
  top: -20px;
  left: -10px;
  position: absolute;
  background: transparent;
}
.screen-profile .content .boatdays .swiper-pagination {
  bottom: 15px;
}
.screen-profile .content .boatdays .swiper-pagination-bullet {
  width: 8px;
  height: 8px;
  border-radius: 8px;
  background: #b1bfcc;
}
.screen-profile .content .boatdays .swiper-pagination-bullet-active {
  background: #11abc1;
}
.screen-profile-picture .profile-picture {
  margin: auto;
}
.screen-profile-picture p.display-name {
  text-align: center;
}
.screen-sign-in .btn.facebook {
  border-color: #6782bc;
  color: white;
  background: #6782bc;
}
.screen-sign-in .btn.twitter {
  border-color: #3ad2fe;
  color: white;
  background: #3ad2fe;
}
.screen-sign-in img.or {
  width: 30%;
  display: block;
  margin: 25px auto;
}
.screen-notifications .header {
  border-bottom: 1px solid #e1e6ea;
  text-align: center;
}
.screen-notifications .header h1 {
  margin-bottom: 5px;
  margin-top: 50px;
}
.screen-notifications .header p {
  color: ;
  font-size: 0.6em;
  margin-bottom: 30px;
}
.screen-notifications .notification {
  border-bottom: 1px solid #e1e6ea;
  background: white;
  min-height: 72px;
}
.screen-notifications .notification.read {
  border-bottom: 1px solid #e1e6ea;
  background: #f9fbfb;
}
.screen-notifications .notification .profile-picture {
  margin: 0px 10px 0px 0px;
  width: 40px;
  height: 40px;
  float: left;
  border: 1px solid #11abc1;
}
.screen-notifications .notification .bd-picture {
  margin: 0px 10px 0px 0px;
  width: 40px;
  height: 40px;
  float: left;
}
.screen-notifications .notification p {
  padding: 10px;
  margin: 0px;
  line-height: normal;
  font-weight: 500;
  font-size: 0.75em;
}
.screen-notifications .notification span.sender {
  color: #11abc1;
  line-height: 20px;
  display: block;
}
.screen-notifications .notification span.time {
  margin: 0px;
  margin-bottom: 5px;
  line-height: 20px;
  display: block;
  font-weight: 400;
  color: #b1bfcc;
}
.screen-boatdays-home .category {
  height: 25%;
  border-bottom: 4px solid rgba(13, 13, 14, 0.79);
  background: center center no-repeat;
  background-size: cover;
}
.screen-boatdays-home .category h1 {
  margin: 0px;
  text-align: right;
  position: absolute;
  bottom: 0px;
  right: 0px;
  background: rgba(13, 13, 14, 0.79);
  font-size: 20px;
  padding: 10px 12px 5px 5px;
  color: white;
  font-family: museo;
}
.screen-boatdays-home .category h1:after {
  content: "";
  position: absolute;
  top: 0px;
  left: -100%;
  height: 100%;
  width: 100%;
  background: url(../resources/boatday-category-corner.png) top right no-repeat;
}
.screen-boatdays-home header.bar.bar-nav {
  background: transparent;
  border: none;
}
.screen-boatdays-home header.bar.bar-nav a.icon {
  color: #546e7a;
}
.screen-boatdays-home .content {
  padding-top: 0px;
}
.screen-boatdays .content,
.screen-boatdays-past .content,
.screen-boatdays-upcoming .content {
  background: #f4f9f9;
}
.screen-boatdays .boatday-card,
.screen-boatdays-past .boatday-card,
.screen-boatdays-upcoming .boatday-card {
  display: relative;
  margin: 15px;
  background: transparent;
}
.screen-boatdays .boatday-card .boat-img,
.screen-boatdays-past .boatday-card .boat-img,
.screen-boatdays-upcoming .boatday-card .boat-img {
  height: 200px;
  position: relative;
}
.screen-boatdays-past .boatday-card .boat-img,
.screen-boatdays-upcoming .boatday-card .boat-img {
  height: 250px;
}
.screen-boatdays .boatday-card .details,
.screen-boatdays-past .boatday-card .details,
.screen-boatdays-upcoming .boatday-card > .details,
.screen-boatdays-upcoming .boatday-card > div:last-child {
  background: white;
  padding: 15px;
  pading-top: 0px;
  border: 1px solid #e1e6ea;
  border-top: none;
  border-bottom-left-radius: 15px;
  border-bottom-right-radius: 15px;
}
.screen-boatdays-upcoming .boatday-card > div.details:not(:last-child) {
  border-radius: 0px;
}
.screen-boatdays-upcoming .boatday-card > div.chat {
  background: #f9fbfb;
}
.screen-boatdays-upcoming .boatday-card > div.chat a {
  color: #13a7bf;
  display: block;
  font-weight: 500;
  text-align: center;
  font-size: 0.8em;
}
.screen-boatdays-upcoming .boatday-card > div.chat .new {
  background: #f9fbfb;
  font-size: 0.7em;
  text-align: center;
  margin-bottom: 0px;
}
.screen-boatdays-upcoming .boatday-card > div.chat .new span.bullet {
  background: #f5b019;
  width: 10px;
  height: 10px;
  display: inline-block;
  border-radius: 10px;
}
.screen-boatdays-past .boatday-card .details {
  padding-top: 40px;
}
.screen-boatdays .boatday-card .boat-img *,
.screen-boatdays-past .boatday-card .boat-img *,
.screen-boatdays-upcoming .boatday-card .boat-img * {
  line-height: normal;
}
.screen-boatdays .boatday-card .boat-img .picture,
.screen-boatdays-past .boatday-card .boat-img .picture,
.screen-boatdays-upcoming .boatday-card .boat-img .picture {
  width: 100%;
  height: 100%;
  background: center center no-repeat url(../resources/boat-placeholder.png) transparent;
  background-size: cover;
  border-top-left-radius: 15px;
  border-top-right-radius: 15px;
}
.screen-boatdays .boatday-card .boat-img .price {
  background: rgba(13, 13, 14, 0.75);
  margin: auto;
  width: 120px;
  padding: 7px;
  border-bottom-left-radius: 7px;
  border-bottom-right-radius: 7px;
  font-size: 1.4em;
  color: white;
  text-align: center;
}
.screen-boatdays .boatday-card .boat-img .favorite {
  position: absolute;
  top: 15px;
  right: 30px;
  font-size: 1.5em;
  color: rgba(255, 255, 255, 0.75);
  fot-weight: bold;
  text-shadow: 0px 4px 4px rgba(13, 13, 14, 0.25), 4px 0px 4px rgba(13, 13, 14, 0.25), 0px -4px 4px rgba(13, 13, 14, 0.25), -4px 0px 4px rgba(13, 13, 14, 0.25);
}
.screen-boatdays .boatday-card .boat-img .price sup {
  color: white;
  font-size: 0.7em;
}
.screen-boatdays .boatday-card .boat-img .price sub {
  color: white;
  font-size: 0.4em;
}
.screen-boatdays .boatday-card .boat-img .owner .profile-picture,
.screen-boatdays-past .boatday-card .boat-img .owner .profile-picture,
.screen-boatdays-upcoming .boatday-card .boat-img .owner .profile-picture {
  background: center center no-repeat white;
  background-size: cover;
  height: 60px;
  width: 60px;
  border-radius: 70px;
  border: 2px solid white;
  position: absolute;
  bottom: -15px;
  left: 15px;
}
.screen-boatdays-past .boatday-card .boat-img .owner .profile-picture {
  left: 50%;
  bottom: -30px;
  margin-left: -30px;
}
.screen-boatdays .boatday-card .boat-img .owner .name,
.screen-boatdays-upcoming .boatday-card .boat-img .owner .name {
  position: absolute;
  bottom: -15px;
  left: 85px;
  line-height: 60px;
  background: transparent;
  color: white;
  font-size: 0.7em;
}
.screen-boatdays .boatday-card .boat-img .owner .name strong,
.screen-boatdays-upcoming .boatday-card .boat-img .owner .name strong {
  font-weight: 500;
}
.screen-boatdays .boatday-card .boat-img .owner .rating,
.screen-boatdays-upcoming .boatday-card .boat-img .owner .rating {
  position: absolute;
  bottom: -15px;
  line-height: 60px;
  right: 15px;
  font-size: 0.6em;
  color: white;
}
.screen-boatdays .boatday-card .boat-img .owner .rating img,
.screen-boatdays-past .boatday-card .boat-img .owner .rating img,
.screen-boatdays-upcoming .boatday-card .boat-img .owner .rating img {
  height: 12px;
  position: relative;
  top: 2px;
}
.screen-boatdays .boatday-card .details .date,
.screen-boatdays-past .boatday-card .details .date,
.screen-boatdays-upcoming .boatday-card .details .date,
.screen-boatdays .boatday-card .details .duration,
.screen-boatdays-upcoming .boatday-card .details .duration,
.screen-boatdays .boatday-card .details .position,
.screen-boatdays-upcoming .boatday-card .details .position,
.screen-boatdays .boatday-card .details .seats,
.screen-boatdays-past .boatday-card .details .captain {
  font-size: 0.8em;
  color: #546e7a;
  line-height: 20px;
}
.screen-boatdays .boatday-card .details strong,
.screen-boatdays-upcoming .boatday-card .details strong {
  color: #13a7bf;
  font-size: 1.6em;
  font-weight: 500;
}
.screen-boatdays .boatday-card .details .position,
.screen-boatdays-upcoming .boatday-card .details .position {
  color: #b2c0cc;
  padding-top: 15px;
  text-align: left;
}
.screen-boatdays-upcoming .boatday-card .details .position {
  margin-right: 0px;
}
.screen-boatdays .boatday-card .details .seats {
  color: #b2c0cc;
  width: 50px;
  text-align: center;
  float: right;
  margin-top: 12px;
}
.screen-boatdays-upcoming .boatday-card .details .status {
  float: none;
  text-align: center;
  color: #13a7bf;
  margin-top: 20px;
}
.screen-boatdays .boatday-card .details h1,
.screen-boatdays-past .boatday-card .details h1,
.screen-boatdays-upcoming .boatday-card .details h1 {
  margin: 0px;
  text-align: left;
  font-size: 1.1em;
  font-weight: 500;
  line-height: 35px;
  color: #13a7bf;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}
.screen-boatdays-past .boatday-card .details .captain {
  color: #b2c0cc;
}
.screen-boatdays-past .boatday-card .details .captain strong {
  color: #13a7bf;
}
.screen-boatdays-past .boatday-card .details h1 {
  text-align: center;
  color: #546e7a;
}
.screen-boatdays-past .boatday-card .header {
  position: absolute;
  height: 80px;
  top: 50%;
  width: 100%;
  margin-top: -40px;
  background: rgba(43, 51, 54, 0.85);
}
.screen-boatdays-past .boatday-card .header * {
  color: white;
}
.screen-boatdays-past .boatday-card .header .left,
.screen-boatdays-past .boatday-card .header .center,
.screen-boatdays-past .boatday-card .header .right {
  width: 50%;
  text-align: center;
  color: white;
  font-weight: 500;
  font-size: 0.8em;
  margin-top: 20px;
}
.screen-boatdays-past .boatday-card .header .center {
  width: 100%;
  line-height: 80px;
  margin-top: 0px;
}
.screen-boatdays-past .boatday-card .header .left {
  float: left;
}
.screen-boatdays-past .boatday-card .header .right {
  float: right;
}
.screen-boatdays-past .boatday-card .header .left strong {
  font-size: 1.5em;
}
.screen-boatdays-past .boatday-card .header .right img {
  height: 12px;
  position: relative;
  top: 2px;
}
.screen-boatdays-past .boatday-card .details .captain {
  color: #b2c0cc;
}
.screen-boatdays-past .boatday-card .details .captain strong {
  color: #13a7bf;
  font-weight: 500;
}
.screen-boatdays .content .filters .location {
  text-align: center;
  margin: 0px;
}
.screen-boatdays .logo-placeholder {
  margin-top: 60px;
}
.screen-boatday .slider {
  background: #b2c0cc;
}
.screen-boatday .captain {
  background: #f9fbfb;
  padding: 20px 20px;
}
.screen-boatday .captain .profile-picture {
  width: 80px;
  height: 80px;
  float: left;
  border: 2px white solid;
  margin-right: 20px;
}
.screen-boatday .captain p {
  font-size: 0.8em;
  line-height: 25px;
  margin-top: 0px;
  color: #b2c0cc;
  font-weight: 500;
}
.screen-boatday .captain p strong {
  font-weight: 500;
  color: #546e7a;
}
.screen-boatday .captain p img.rating {
  height: 14px;
  position: relative;
  top: 2px;
}
.screen-boatday .captain p.certifications {
  text-align: center;
  margin-top: 20px;
}
.screen-boatday .captain p.certifications img {
  height: 28px;
  margin: 0px 5px;
}
.screen-boatday .content h1 {
  margin: 45px 0px;
  line-height: normal;
  font-size: 1.1em;
  font-weight: 400;
}
.screen-boatday table {
  width: 100%;
}
.screen-boatday td {
  border-top: 1px solid #e1e6ea ;
  border-bottom: 1px solid #e1e6ea ;
  padding: 15px 10px;
  font-size: 0.7em;
  font-weight: 500;
}
.screen-boatday td span {
  color: #13a7bf;
}
.screen-boatday td strong {
  color: #546e7a;
  padding-left: 5px;
}
.screen-boatday td:first-child {
  border-right: 1px solid #e1e6ea ;
}
.screen-boatday label {
  display: block;
  font-weight: 700;
  text-align: center;
  color: #b2c0cc;
  font-size: 0.75em;
  margin-bottom: 10px;
  margin-top: 40px;
  clear: both;
}
.screen-boatday p.description {
  text-align: justify;
  margin-bottom: 40px;
}
.screen-boatday .map {
  height: 200px;
  background: #f9fbfb;
  border-radius: 5px;
  background: center center no-repeat;
  position: relative;
}
.screen-boatday .map img {
  width: 100px;
  height: 100px;
  position: absolute;
  top: 50%;
  left: 50%;
  margin-top: -50px;
  margin-left: -50px;
}
.screen-boatday .features {
  margin-bottom: 20px;
}
.screen-boatday .features p {
  width: 50%;
  float: left;
  padding: 0px 10px;
  margin-bottom: 5px;
  font-weight: 500;
  font-size: 0.7em;
}
.screen-boatday .features img {
  width: 10px;
  margin-right: 5px;
}
.screen-boatday .position strong {
  font-size: 1.5em;
  position: relative;
  top: 2px;
  margin-right: 5px;
  color: #13a7bf;
}
.screen-boatday .position {
  font-size: 0.8em;
  text-align: center;
  margin-top: 5px;
}
.screen-boatday .book {
  clear: both;
  background: #f9fbfb;
  padding: 20px 0px;
}
.screen-boatday .book p.price {
  font-size: 3em;
  text-align: center;
  font-weight: 200;
  line-height: normal;
}
.screen-boatday .book p.price sup {
  font-size: 0.45em;
  position: relative;
  top: -20px;
}
.screen-boatday .book p.price sub {
  font-size: 0.3em;
}
.screen-boatday .book p.seats {
  text-align: center;
  color: #13a7bf;
  font-weight: 500;
  margin-bottom: 20px;
}
.screen-boatday .book a.btn-cancel-modal {
  display: block;
  margin-top: 20px;
  text-align: center;
  font-size: 0.7em;
  font-weight: 500;
}
.screen-boatday .btn.btn-action {
  margin-top: 15px;
}
.screen-boatday .badge-price {
  background: rgba(13, 13, 14, 0.75);
  margin: auto;
  width: 120px;
  padding: 7px;
  border-bottom-left-radius: 7px;
  border-bottom-right-radius: 7px;
  font-size: 1.4em;
  color: white;
  text-align: center;
  position: absolute;
  top: 60px;
  z-index: 1;
  left: 50%;
  margin-left: -60px;
}
.screen-boatday .badge-price sup {
  font-size: 0.7em;
  color: white;
}
.screen-boatday .badge-price sub {
  font-size: 0.4em;
  color: white;
}
.screen-boatday .slide .img {
  min-height: 200px;
  width: 100%;
  background: center center no-repeat;
  background-size: cover;
}
.screen-boatday .confirmed-guests .guest span {
  color: #b2c0cc;
  font-weight: 400;
  line-height: auto;
}
.screen-boatday .confirmed-guests .guest {
  text-align: center;
  width: 25%;
  font-size: 0.7em;
  font-weight: 500;
  color: #13a7bf;
  float: left;
  margin-bottom: 20px;
  line-height: auto;
}
.screen-boatday .confirmed-guests .guest .profile-picture {
  margin: auto;
}
.screen-boatday .total-pictures {
  position: absolute;
  color: red;
  bottom: 10px;
  right: 10px;
  color: white;
  font-size: 0.95em;
  z-index: 2;
  text-shadow: 1px 1px 2px rgba(0, 0, 0, 0.8), -1px -1px 2px rgba(0, 0, 0, 0.8), -1px 1px 2px rgba(0, 0, 0, 0.8), 1px -1px 2px rgba(0, 0, 0, 0.8);
}
.screen-boatday .questions-list .inner.q,
.screen-boatday .questions-list .inner.a {
  border-top: 1px solid #E1E6EA;
  padding: 20px;
}
.screen-boatday .questions-list .inner.a {
  background: #F9FBFB;
}
.screen-boatday .questions-list .inner.q p {
  color: #546E7A;
  margin: 0px;
}
.screen-boatday .questions-list .inner.a p {
  color: #B1BFCC;
  margin: 0px;
}
.screen-boatday .questions-list {
  margin-bottom: 30px;
}
.screen-boatday .questions-list .questions:not(.empty) {
  border-bottom: 1px solid #E1E6EA;
}
.screen-boatday .questions-list button {
  padding: 5px 10px;
  margin-top: 20px;
}
.screen-boatday .questions-list table,
.screen-boatday .questions-list table tr,
.screen-boatday .questions-list table tr td {
  border: none;
  padding: 0px;
  margin: 0px;
  font-weight: normal;
  color: #546E7A;
}
.screen-boatday .questions-list table tr td:last-child {
  padding-left: 10px;
  text-align: right;
}
.screen-boatday .questions-list .question-toggle img {
  width: 24px;
}
.screen-boatday-chat.modal {
  background: transparent;
}
.screen-boatday-chat .content {
  background: rgba(43, 51, 54, 0.85);
  margin-bottom: 50px;
}
.screen-boatday-chat .line {
  margin-top: 15px;
  clear: both;
}
.screen-boatday-chat .text {
  margin-left: 50px;
}
.screen-boatday-chat .me .text {
  margin-right: 50px;
}
.screen-boatday-chat .profile-picture {
  width: 40px;
  height: 40px;
  float: left;
}
.screen-boatday-chat .me .profile-picture {
  width: 40px;
  height: 40px;
  float: right;
}
.screen-boatday-chat .speech-bubble {
  background: #f9fbfb;
  border-radius: 5px;
  padding: 10px;
  float: left;
  display: inline-block;
  margin-left: 15px;
  position: relative;
  border: 1px solid #e0ebed;
}
.screen-boatday-chat .speech-bubble:after {
  content: "";
  position: absolute;
  width: 20px;
  height: 20px;
  top: 5px;
  left: -19px;
  background: url(../resources/speech-bubble-left.png) top left no-repeat;
}
.screen-boatday-chat .me .speech-bubble:after {
  left: auto;
  right: -19px;
  background: url(../resources/speech-bubble-right.png) top right no-repeat;
}
.screen-boatday-chat .me .speech-bubble {
  float: right;
  margin-left: 0px;
  margin-right: 15px;
}
.screen-boatday-chat .speech-bubble p {
  margin: 0px;
}
.screen-boatday-chat .field {
  margin-right: 50px;
}
.screen-boatday-chat .field input[type="text"] {
  border-radius: 0px;
  border-left: none;
  border-right: none;
  border-bottom: none;
  float: left;
  margin: 0px;
}
.screen-boatday-chat button {
  width: 50px;
  height: 52px;
  float: right;
  border-radius: 0px;
  border-right: none;
  border-bottom: none;
}
.screen-boatday-book p {
  text-align: center;
}
.screen-boatday-book select {
  font-size: 1.1em;
  text-align: center;
}
.screen-boatday-book .seats {
  margin-top: 30px;
  background: #f9fbfb;
  padding-top: 30px;
  padding-bottom: 30px;
}
.screen-boatday-book .seats table {
  width: 100%;
  margin-top: 20px;
}
.screen-boatday-book .seats table tr td {
  line-height: 35px;
}
.screen-boatday-book .seats table tr td.label {
  color: #546e7a ;
  font-weight: 500;
  font-size: 0.8em;
}
.screen-boatday-book .seats table tr td.amount-seats {
  color: #b1bfcc;
  line-height: 35px;
  font-size: 1.15em;
}
.screen-boatday-book .seats table tr td.amount {
  color: #546e7a;
  text-align: right;
  font-weight: 500;
}
.screen-boatday-book .seats table tr.discount td.amount,
.screen-boatday-book .seats table tr.discount-per-seat td.amount,
.screen-boatday-book .seats table tr.promo td.amount,
.screen-boatday-book .seats table tr.promo-per-seat td.amount {
  color: #23acc2;
}
.screen-boatday-book .seats p {
  text-align: right;
  margin-top: 25px;
  border-top: 1px solid #e1e6ea;
  padding-top: 25px;
}
.screen-boatday-book .seats .price-total {
  font-size: 2.4em;
  font-weight: 2em;
  padding-right: 10px;
}
.screen-boatday-book .seats .add-promo {
  float: left;
  font-size: 1em;
  padding-left: 10px;
}
.screen-boatday-book .seats p sup {
  font-size: 0.6em;
  position: relative;
}
.screen-boatday-book .payment {
  margin-top: 25px;
}
.screen-boatday-book .submit-request p {
  font-size: 0.7em;
}
.screen-boatday-cancellation .policy {
  margin-bottom: 40px;
}
.screen-boatday-cancellation .policy:not(.active) h1,
.screen-boatday-cancellation .policy:not(.active) p {
  color: #b2c0cc;
}
.screen-boatday-active .content {
  background: -webkit-linear-gradient(-105deg, #0ab8c8, #13a7bf);
}
.screen-boatday-active .logo {
  width: 140px;
  max-width: 70%;
  display: block;
  margin: 60px auto 40px auto;
}
.screen-boatday-active .welcome {
  color: white;
  line-height: normal;
  font-size: 1em;
  font-weight: 400;
  text-align: center;
}
.screen-boatday-active .btn {
  border-color: white;
  background: transparent;
  border-width: 1px;
  color: white;
  font-size: 1em;
  font-weight: 200;
}
.screen-boatday-active .btn:active,
.screen-boatday-active .btn.active {
  border-color: white;
  background: rgba(255, 255, 255, 0.25);
}
.screen-boatday-active .actions {
  margin-top: 45px;
  background: rgba(43, 51, 54, 0.85);
  text-align: center;
}
.screen-boatday-active .actions .option {
  display: inline-block;
  text-align: center;
  margin: 20px 10px;
}
.screen-boatday-active .actions .option a {
  display: inline-block;
  width: 50px;
  height: 50px;
  line-height: 50px;
  text-align: center;
  border: 1px solid white;
  border-radius: 50px;
}
.screen-boatday-active .actions .option a span {
  color: white;
  font-size: 1.3em;
}
.screen-boatday-active .actions .option span.label {
  display: inline-block;
  color: white;
  font-size: 0.6em;
  line-height: normal;
  margin-top: 10px;
}
.screen-boatday-pay .stars {
  margin-bottom: 15px;
}
.screen-boatday-pay .stars img {
  margin: 0px 5px;
  max-width: 20px;
}
.screen-boatday-pay textarea {
  margin-bottom: 0px;
}
.screen-boatday-pay .grey-area {
  background: #f9fbfb;
  padding: 20px 0px;
  margin: 15px 0px;
  text-align: center;
  color: #546e7a;
  line-height: auto;
}
.screen-boatday-pay .grey-area .seats {
  font-size: 2em;
  font-weight: 200;
  line-height: normal;
}
.screen-boatday-pay .grey-area .price {
  font-size: 3em;
  font-weight: 200;
  line-height: normal;
}
.screen-boatday-pay .grey-area .price sup {
  font-size: 0.45em;
  position: relative;
  top: -20px;
}
.screen-boatday-pay .grey-area a {
  display: block;
  font-size: 0.75em;
  font-weight: 400;
}
.screen-boatday-pay .grey-area a.btn-adjust {
  margin: 20px 0px 10px 0px;
}
.screen-boatday-pay .grey-area a .icon {
  font-size: 0.75em;
  font-weight: 500;
  margin-left: 5px;
}
.screen-boatday-pay .grey-area .btn-minus,
.screen-boatday-pay .grey-area .btn-plus {
  font-size: 1.5em;
  min-width: 50px;
  margin: 0px 10px;
  margin: 10px;
  font-weight: 400;
}
.screen-boatday-pay .details table {
  width: 100%;
  margin-top: 20px;
}
.screen-boatday-pay .details table tr td {
  line-height: 35px;
}
.screen-boatday-pay .details table tr td.label {
  color: #546e7a ;
  font-weight: 500;
  font-size: 0.8em;
  text-align: left;
}
.screen-boatday-pay .details table tr td.amount-seats {
  color: #b1bfcc;
  line-height: 35px;
  font-size: 1.15em;
}
.screen-boatday-pay .details table tr td.amount {
  color: #546e7a;
  text-align: right;
  font-weight: 500;
}
.screen-boatday-pay .details table tr.discount td.amount,
.screen-boatday-pay .details table tr.discount-per-seat td.amount,
.screen-boatday-pay .details table tr.promo td.amount,
.screen-boatday-pay .details table tr.promo-per-seat td.amount {
  color: #23acc2;
}
.screen-boatday-pay .details p {
  text-align: right;
  margin-top: 25px;
  border-top: 1px solid #e1e6ea;
  padding-top: 25px;
}
.screen-boatday-pay .details .price-total {
  font-size: 2.4em;
  font-weight: 2em;
  padding-right: 10px;
}
.screen-certifications .ico-cert {
  display: blocK;
  margin: auto;
  margin-top: 20px;
  margin-bottom: 5px;
}
.screen-boat .content .grey-area {
  background: #f9fbfb;
  border-bottom: 2px solid rgba(29, 29, 28, 0.05);
}
.screen-boat .content .boat-card {
  height: 166px;
  width: 174px;
  text-align: center;
  background-size: cover;
}
.screen-boat .content .boat-card h1 {
  font-weight: 400;
  font-size: 10pt;
  line-height: 14pt;
}
.screen-boat .content .boat-card h2 {
  font-weight: 400;
  font-size: 8.5pt;
  line-height: 12pt;
}
.screen-boat .content .grey-area .boat-info {
  padding: 36px 80px 31px 80px;
}
.screen-boat .content .grey-area .boat-info #capacity h3,
.screen-boat .content .boat-info #capacity p {
  display: inline;
  margin-bottom: 11px;
}
.screen-boat .content .grey-area .boat-info #length h3,
.screen-boat .content .grey-area .boat-info #length p {
  display: inline;
  margin-bottom: 11px;
}
.screen-boat .content .grey-area .boat-info #type h3,
.screen-boat .content .grey-area .boat-info #type p {
  display: inline;
}
.screen-boat .content .grey-area .boat-info h3 {
  color: #b1bfcc;
  font-size: 11.5pt;
  font-weight: 400;
  line-height: 13pt;
  padding-right: 3px;
}
.screen-boat .content .grey-area .boat-info p {
  padding-left: 3px;
}
.screen-boat .content .boat-amenities h3 {
  color: #546e7a;
  font-size: 9pt;
  font-weight: 400;
  line-height: 14pt;
  margin: 0px 105px 30px 105px;
  padding: 4px 14px 6px 14px;
  background: #dfeff1;
  display: inline-block;
  border-radius: 0px 0px 2pt 2pt;
}
.screen-boat .content .boat-amenities .features {
  margin: 30px 0px 30px 0px;
}
.screen-boat .content .boat-amenities .features p {
  font-weight: 400;
  color: #546e7a;
  font-size: 10.5pt;
  line-height: 19pt;
  text-align: center;
}
