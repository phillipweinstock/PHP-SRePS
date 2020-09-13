$url="https://www.apachefriends.org/xampp-files/7.2.33/xampp-windows-x64-7.2.33-0-VC15-installer.exe"
Write-Host "Congratulations on installing the PHP-SReps software"
Write-Host "Please wait as we download the required software"
Write-Host "This Program should automatically close after it finishs"

#$outpath = "$($env:USERPROFILE)\Desktop\Powershell\xamp.exe"
$runpath = "$PSScriptRoot\xamp.exe"

Invoke-WebRequest -Uri $url -OutFile $runpath
Invoke-Expression "& `$runpath` --installer-language en --mode unattended --disable-components xampp_filezilla,xampp_mercury,xampp_tomcat,xampp_perl,xampp_phpmyadmin,xampp_webalizer,xampp_sendmail"
#
Write-Host "Currently installing please wait"

Start-Sleep -s 30
#Start MYSQL Server
#start-process "C:\xampp\mysql_start.bat"
#Setup mysql in here
$Password = Read-Host -Prompt 'What would you like the root password to be'
#Invoke-Expression "& `C:\xampp\mysql\bin\mysql.exe`"
#Invoke-Expression "& `C:\xampp\mysql\bin\mysqladmin.exe` -u root password `"$Password`" "
#Stop MYSQL Server
start-process "C:\xampp\mysql_stop.bat"
Read-Host -Prompt 'Press Enter to exit'