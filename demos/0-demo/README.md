# DEMO: Running docker first time​

1. Run docker on remote <https://labs.play-with-docker.com/>
   1. Consider to remove unnecessary items from screen and increase font - `document.querySelector('.stats').remove()`
   2. Consider to open docs to the side.
2. Run `docker version` and show that there are a client and engine
   1. Show that there is different clients on windows installed (e.g. in Powershell and WSL2) but one docker engine
3. <https://hub.docker.com/r/docker/whalesay>
   1. `docker run docker/whalesay cowsay Hello,itvdn!`
   2. Explain what had happened
4. Run `docker image list` and show what we have
5. Run `docker image pull docker/whalesay` to show that image is downloaded on host
6. Run `docker image history <id>`
7. Run `docker container run --name itvdn-whale docker/whalesay cowsay Hello,itvdn`
8. Show docker log, explain it
   1. `docker container list --all` and pick container
   2. `docker log <id>` OR `docker log itvdn-whalesay`
9.  Run `docker rm <id>` // pick subpart of Id
10. Create a bunch of other containers to delete them at the end.
11. Run `docker container prune`

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
