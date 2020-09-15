# DEMO: Running docker first time​

1. Run docker on remote <https://labs.play-with-docker.com/>
   1. Consider to remove unnecessary items from screen and increase font - `document.querySelector('.stats').remove()`
2. <https://hub.docker.com/r/docker/whalesay>
   1. `docker run docker/whalesay cowsay Hello,itvdn!`
   2. Explain what had happened
3. Run `docker image list` and show what we have
4. Run `docker image pull docker/whalesay` to show that image is downloaded on host
5. Run `docker container run --name itvdn-whale idocker/whalesay cowsay Hello,itvdn`
6. Show docker log, explain it
   1. `docker container list --all` and pick container
   2. `docker log <id>` OR `docker log itvdn-whalesay`
   3. TODO: consider to add more info about logs
7. Run `docker container prune`
8. Run `clear` `docker version | less` and show that there are a client and engine

## Concepts & Ideas

* 💡: containers are lightweight
* 💡: container are disposable, data is shared in writable layer
* 💡: docker containers are built based on images
  * images are cached and shared, really optimized
* 💁‍♂️ Docker containers could be identified by partial Id unique to docker host
* 💡 docker lifecycle
  * docker cli-> docker daemon-> docker registry -> docker image -> docker container -> docker engine

## Highlighted commands

* `docker run`, `docker container run`
* `docker ps`, `docker container list`
* `docker images`, `docker image list`
* `docker image pull`
* `docker log`
* `docker container prune`
* `docker version`
