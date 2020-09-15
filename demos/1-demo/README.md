# DEMO: Running docker second time

1. Open docker dashboard
2. ![docker-dashboard](../../docs/assets/docker-dashboard.png)
3. Run `docker container run --rm --interactive --tty alpine`
   1. Mention: `--detach`
4. Inside container run:
   1. `whoami` 
   2. `hostname`
   3. `top`
   4. `date && cal`, interestingly date is shared from host
   5. `echo 'echo running...' > script.sh`
   6. `chmod +x ./script.sh`
   7. `./script.sh`
5. Open new pane: split (without closing of first terminal)
   1. Run `docker container exec --workdir / <id> /bin/sh h1.sh`
6. Show detached mode
   1. `docker container create -it --name demo1-alpine alpine`
   2. `docker container attach demo1-alpine`
   3. `docker container attach demo1-alpine`
   4. `find . -name *.sh`
7. Run `docker container top demo1-alpine`
8. Run `docker container logs demo1-alpine --follow`
9. Open new pane: split
10. Run `docker container inspect demo1-alpine | code - &`
    1. Id
    2. State
    3. Image
    4. LogPath
    5. Mounts
    6. NetworkSettings
11. `docker container rm --force <id>`

### Bonus

TODO: dotnet-script demo OR tar

## Concepts & Ideas

* 💡 interactive mode
* 💡 how to manage docker containers and get more information
  * `docker container top`
  * `docker container inspect`
  * ...
