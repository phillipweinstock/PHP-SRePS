$url="https://www.apachefriends.org/xampp-files/7.2.33/xampp-windows-x64-7.2.33-0-VC15-installer.exe"
#self elevates to administrator, 
#why? because who wants to keep on clicking run as admin
if (!([Security.Principal.WindowsPrincipal][Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator")) { Start-Process powershell.exe "-NoProfile -ExecutionPolicy Bypass -File `"$PSCommandPath`"" -Verb RunAs; exit }
#kudos 
#https://stackoverflow.com/questions/7690994/running-a-command-as-administrator-using-powershell
# 
Write-Host "Congratulations on installing the PHP-SReps software"
Write-Host "Please wait as we download the required software"
Write-Host "This Program should automatically close after it finishs"
Write-Host "Please note, if you have a db already set up on this device, please do not"
Write-Host "Run this script, as it may make your installation unstable"
Write-Host "If this is the case, please manually spin up the Database"



Read-Host -Prompt 'Press Enter to Continue'
Write-Host "WARNING DO NOT PRESS ENTER TILL NAME ENTERED OR YOU INSTALLATION WILL BE BROKEN"
$name_db = Read-Host -Prompt 'What would you like the DB to be called'
Write-Host "WARNING DO NOT PRESS ENTER TILL PASSWORD ENTERED OR YOU INSTALLATION WILL BE BROKEN"
$Password = Read-Host -Prompt 'What would you like the root password to be'
#Download the package
$runpath = "$PSScriptRoot\xamp.exe"
$sqlfilePath = "$PSScriptRoot\sales_maybe.sql"
$db_builder = Get-Content $sqlfilePath -Raw
Write-Host "Please wait as we download the required software"

Invoke-WebRequest -Uri $url -OutFile $runpath

Write-Host "Currently installing please wait"
Write-Host "This may take some time, after the installation is complete the DB will be spun up"
#run the installation 
Start-process -wait -FilePath $runpath -ArgumentList "--installer-language en --mode unattended --disable-components xampp_filezilla,xampp_mercury,xampp_tomcat,xampp_perl,xampp_phpmyadmin,xampp_webalizer,xampp_sendmail" -Verb RunAs




#Start MYSQL Server
start-process "C:\xampp\mysql_start.bat"
Start-Sleep -s 5
#Setup mysql in here
Invoke-Expression "& `C:\xampp\mysql\bin\mysql.exe` -u root -e `"create database $name_db;`""
#magic demonic stuff lmao
Invoke-Expression "& `C:\xampp\mysql\bin\mysql.exe` -u root $name_db -e `"$db_builder`""

#dont press enter or else lmao
Invoke-Expression "& `C:\xampp\mysql\bin\mysqladmin.exe` -u root password `"$Password`" "
#Stop MYSQL Server
start-process "C:\xampp\mysql_stop.bat"
Start-Sleep -s 5
start-process "C:\xampp\mysql_start.bat"
Read-Host -Prompt 'Press Enter to exit'