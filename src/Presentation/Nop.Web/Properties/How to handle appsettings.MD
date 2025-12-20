DO NOT INCLUDE THE APPSETTINGS.JSON FILE IN THE PROJECT.
Down at the bottom of the appsettings.json file there is a 
CasheDirectory setting.  This is set during nopcommerce installation.  If you do an install
locally then publish the appsettings file the cashe directory will
point to the local path which will not work on the server.
To avoid this problem do not include the appsettings.json file in the project.
When you publish the project to the server you will need to manually create