#!/bin/bash
alias CWD='printf%q\n"$(pwd)"|pbcopy'
# To Install:
#apt install net-tools  # installs the tools req.
# downloads the installer
#wget -O installer https://downloadsapachefriends.global.ssl.fastly.net/7.3.0/xampp-linux-x64-7.3.0-0-installer.run?from_af=true
# gives permission to run installer
#chmod +x 'installer' 
# starts installer
#./installer --mode unattended --launchapps 1 


# Getting inputs for database name and password.
echo "Enter the database name"
read database_name
echo "Enter the password"
read password


# start Mysql:
#/opt/lampp/lampp startmysql

#Open Mysql Terminal:

/opt/lampp/bin/mysql -u root -p$password
/opt/lampp/bin/mysql -u root -p$password -e"CREATE database $database_name"
/opt/lampp/bin/mysql -u root -p$password $database_name < sales_maybe.sql

# For Uninstalling:
#cd /opt/lampp
#./uninstall
#rm -r /opt/lampp

