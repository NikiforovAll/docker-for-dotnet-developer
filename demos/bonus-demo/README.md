# DEMO: Bonus

All you need is vscode + vscode.ms-vscode-remote.vscode-remote-extensionpack, docker and you can start developing dotnet core application on your machine. 🚀

## Script
Inside container:

```bash
docker build -t bonusdemo:latest . | tee bonusdemo.build.log
docker container run --rm --name todo1 -d -P bonusdemo
docker container run --rm --name todo2 -d -P -v /var/run/docker.sock:/var/run/docker.sock bonusdemo:latest
docker inspect <id> | code - &
docker rm -f $(docker ps -a -f ancestor=bonusdemo -q)
```

You can also use vscode extension to manage containers and volumes.

'Docker Images: Build iamge...'

## Concepts & Ideas

* 💡 Devcontainers allows to support developer-environment-as-code
* 👌 I don't have dotnet runtime installed in this devcontainer since I'm running docker inside docker, so the `.devcontainer/Dockerfile` contains bits to run a code.
