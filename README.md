# Materials for .NET Developers to get started with docker

<https://www.theurlist.com/itvdn-docker-for-dotnet-dev>

## Tools setup

* wsl2 (<https://docs.microsoft.com/en-us/windows/wsl/wsl2-kernel>)
* wt.exe
* winget.exe
  * <https://github.com/microsoft/winget-cli>

----

NOT PROCESSED MATERIAL BELOW 👷‍♂️⚒

docker dashboard

https://docs.docker.com/desktop/dashboard/

## Example for .NET Core 

https://github.com/dockersamples/example-voting-app

hello world -> simple web (docker file) -> voting app (docker compose)

https://docs.microsoft.com/en-us/dotnet/architecture/containerized-lifecycle/design-develop-containerized-apps/docker-apps-inner-loop-workflow

--
docker images 

docker image list

docker ps 

docker ps -a 

docker container list (or ls)

docker container ls -a

docker rm $(docker ps -aq)


TODO: consider installing autocompletion for windows or wsl2


docker image history 

docker inspect


TODO: also provide information how to work with mounts and logs inside docker

https://devconnected.com/docker-logs-complete-guide/
https://docs.docker.com/engine/reference/commandline/logs/
https://www.papertrail.com/solution/tips/how-to-live-tail-docker-logs/

--

---



## Getting started 

docker run -d -p 80:80 docker/getting-started

TODO: go through tutorial and see how it can be used in webinar

also consider creating a list of usefuil resources

https://github.com/docker/for-win/issues/2336

## https://stackoverflow.com/questions/30172605/how-do-i-get-into-a-docker-containers-shell

attach to container

## 
docker logs

https://docs.docker.com/engine/reference/commandline/logs/
https://devconnected.com/docker-logs-complete-guide/


https://www.papertrail.com/solution/tips/how-to-live-tail-docker-logs/

---

https://www.docker.com/101-tutorial
https://labs.play-with-docker.com/

follow up resources??
--


https://linuxhandbook.com/list-containers-docker/

https://docs.docker.com/engine/reference/commandline/ps/#filtering
