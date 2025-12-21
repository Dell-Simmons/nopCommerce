Permissions - it's fucking file permissions!  Esp if it fails immediately with nothing in ANY of the logs!!!

ITS FUCKING FILE PERMISSIONS!!!

Be sure to triple check the folder permissions.  Inherit the child 
permissions from the parent folder.  If you have to set them manually, do so.

Make sure the IIS user has read and execute permissions on the folder and files.

I did this on a fresh publish of 4.9.3 and it worked immediately.  Even showed the
install screen.