# .NET Core Docker Sample

This sample demonstrates how to build container images for .NET Core console apps.
The sample builds an application in a [.NET Core SDK container](https://hub.docker.com/_/microsoft-dotnet-core-sdk/) and then copies the build result into a new image (the one you are building) based on the smaller [.NET Core Docker Runtime image](https://hub.docker.com/_/microsoft-dotnet-core-runtime/).

The instructions assume that you have cloned this repo, have [Docker](https://www.docker.com/products/docker) installed, and have a command prompt open within the `samples/dotnetapp` directory within the repo.

## Build a .NET Core image

You can build and run a .NET Core-based container image using the following instructions:

```console
docker build --pull -t dotnetapp .
docker run --rm dotnetapp Hello .NET Core from Docker
```

You can use the `docker images` command to see a listing of your image, as you can see in the following example.

```console
% docker images dotnetapp
REPOSITORY          TAG                 IMAGE ID            CREATED             SIZE
dotnetapp           latest              baee380605f4        14 seconds ago      189MB
```

This Dockerfile copies and restores the project file as the first step so that the results of those commands can be cached for subsequent builds since project file edits are less common than source code edits. Editing a `.cs` file, for example, does not invalidate the layer created by copying and restoring project file, which makes subsequent docker builds much faster.
