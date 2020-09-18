# Materials for .NET Developers to get started with docker

This repository contains materials and demos for .NET developer to get started with docker.

## Related webinar (RU)
youtube.com/watch?v=7j6QhKsLGRw&list=LLPBmZqB43jyARyg_-BtHziA&ab_channel=ITVDN

```bash
$ tree -L 4
.
|-- README.md
|-- demos
|   |-- 0-demo
|   |   `-- README.md
|   |-- 1-demo
|   |   |-- README.md
|   |   `-- main.csx
|   |-- 2-demo
|   |   |-- README.md
|   |   |-- complexapp
|   |   |   |-- Dockerfile
|   |   |   |-- README.md
|   |   |   |-- TestResults
|   |   |   |-- complexapp
|   |   |   |-- complexapp.sln
|   |   |   |-- libbar
|   |   |   |-- libfoo
|   |   |   `-- tests
|   |   `-- dotnetapp
|   |       |-- Dockerfile
|   |       |-- Program.cs
|   |       |-- README.md
|   |       |-- RomanticProfile.cs
|   |       |-- bin
|   |       |-- dotnetapp.csproj
|   |       `-- obj
|   |-- 3-demo
|   |   |-- README.md
|   |   |-- dotnetcompose
|   |   |   |-- Dockerfile
|   |   |   |-- aspnetapp
|   |   |   |-- aspnetapp.sln
|   |   |   `-- docker-compose.yml
|   |   `-- dotnetcompose-mvc
|   |       |-- Program.cs
|   |       |-- Startup.cs
|   |       |-- docker-compose.yml
|   |       |-- dotnetcompose.csproj
|   |       `-- entrypoint.sh
|   `-- bonus-demo
|       |-- README.md
|       `-- bonus
|           |-- Dockerfile
|           |-- config
|           `-- src
`-- docs
    |-- assets
    |   |-- architecture-containers.png
    |   |-- architecture.svg
    |   |-- container-vm-whatcontainer_2.png
    |   |-- container-what-is-container.png
    |   |-- docker-choco.png
    |   |-- docker-dashboard.png
    |   |-- docker-engine.png
    |   |-- docker-ext.png
    |   |-- docker-for-windows-expose-daemon-without-tls.jpg
    |   |-- docker-in-wsl2.png
    |   |-- docker-installer.png
    |   |-- docker-today.png
    |   |-- docker-vs-vms-2.png
    |   |-- engine-components-flow.png
    |   |-- play-with-docker.png
    |   `-- winver.png
    |-- en
    |   |-- 0.1.docker-vs-VM.md
    |   |-- 0.what-is-docker.md
    |   |-- 1.install-docker.md
    |   `-- x.devcontainers.md
    `-- ru

25 directories, 44 files


```

## Reference

<https://www.theurlist.com/itvdn-docker-for-dotnet-dev>
