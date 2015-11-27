cd ~/GitHub/boat-day-app/

bower install
lessc www/css/less/styles.less > www/css/boatday.css

sudo cordova platform add ios
sudo cordova platform add android

sudo cordova plugin add pluginsBase/cordova-plugin-facebook4 --save --variable APP_ID=1442439216059238 --variable APP_NAME=BoatDay
sudo cordova plugin add pluginsBase/cordova-plugin-whitelist
sudo cordova plugin add pluginsBase/cordova-plugin-camera
sudo cordova plugin add pluginsBase/org.apache.cordova.console
sudo cordova plugin add pluginsBase/org.apache.cordova.dialogs
sudo cordova plugin add pluginsBase/org.apache.cordova.geolocation
sudo cordova plugin add pluginsBase/org.apache.cordova.inappbrowser
sudo cordova plugin add pluginsBase/org.apache.cordova.labs.keyboard
sudo cordova plugin add pluginsBase/org.apache.cordova.statusbar
sudo cordova plugin add pluginsBase/org.apache.cordova.file
sudo cordova plugin add pluginsBase/org.apache.cordova.media
sudo cordova plugin add pluginsBase/cordova-plugin-appinfo
sudo cordova plugin add pluginsBase/cordova-plugin-customurlscheme --variable URL_SCHEME=boatday

sudo chown -R Daniel .
sudo chmod -R 777 .