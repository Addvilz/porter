Instructions to recreate Porter build environment.

First of all, You must download Nginx, MySQL and PHP packages.

Afterwards, extract MySQL distribution in Debug or Release subfolder mysql, go to mysql/bin and rename mysqld.exe to porter-mysqld.exe. Then You must create my.ini configuration file in mysql subfolder of Debug or Release. 

Then extract Nginx bdistribution in Debug or Release subfolder nginx, go to nginx folder and rename nginx.exe to porternginx.exe. Then You might want to copy nginx/conf/nginx.conf from original Porter release and replace one in Your nginx/conf with one from Porter release. Next, create htdocs folder in nginx subfolder, if You are using nginx configuration from original Porter distribution. 

Next, extract PHP distribution in Debug or Release subfolder php, rename php-cgi.exe to porter-php-cgi.exe

Remember, PHP-CGI runs under port 19005, so You might want to configure Nginx CGI to use this port.

Good luck.

