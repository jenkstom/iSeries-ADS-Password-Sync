# iSeries-ADS-Password-Synch
This is a password reset program that changes identical usernames on ADS and iSeries then reboots.
This is intended for development environments where access to the iSeries is set to "Use Windows
username and password" and the usernames and passwords must match.

Prerequisites: Client Access 7.1. Maybe other versions will work?

Edit the name for your iseries host (in the Form1.cs / Form1_Load method).

Edit the isUserAdmin function to allow the program to find admin users.

Edit the PrincipalContext with your domain name (rather than "DOMAIN1").

Compile and give access to users. 

Regular users can enter their old password and new password twice.
It will verify the old password against ADS and your iSeries. If the old password matches it will
attempt to set the windows password to the new password. If that fails (because of password requirements)
it will tell the user the password isn't good. If that succeeds, then it changes the iSeries password 
to match and reboots the computer.

Admin users can change any user's passwords. It defaults to their own username, but that can
be changed. The passwords are changed AND the accounts are unlocked, both in ADS and on the iSeries.

This should work in any version of Visual Studio 2017, and maybe earlier versions.
