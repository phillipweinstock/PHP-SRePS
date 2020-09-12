$url="https://www.apachefriends.org/xampp-files/7.2.33/xampp-windows-x64-7.2.33-0-VC15-installer.exe"
#$outpath = "$($env:USERPROFILE)\Desktop\Powershell\xamp.exe"
$runpath = "$PSScriptRoot\xamp.exe"
Invoke-WebRequest -Uri $url -OutFile $runpath
#Invoke-Expression "& `.\$runpath` --installer-language en --mode unattended --disable-components xampp_filezilla,xampp_mercury,xampp_tomcat,xampp_perl,xampp_phpmyadmin,xampp_webalizer,xampp_sendmail"