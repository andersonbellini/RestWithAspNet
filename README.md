# RestWithAspNet
For trainning with restfull apis  cloud using aspnet-core and docker

Docker command

**To list containers
	docker container ps -a 

** To list images
docker image ls

**To create container by MSSQL
docker pull mysql

docker container run --name mysql_treinamento -e MYSQL_ROOT_PASSWORD=123456 -d -p 3306:3306 mysql

**To stop a container that be running 
docker container stop mysql_treinamento

**To starting a container docker created 
docker container start mysql_treinamento


