# DEMO: Dockerfile

## Demo: dotnetapp

* So the idea is to use docker container to build and compile source code inside container
* Open [dotnetapp/Dockerfile](./dotnetapp/Dockerfile)
  * Explain each command by navigating in vscode and invoking "editor.action.showHover"
    * Docker **FROM** sets up base image
      * multi-stage builds
      * mention docker ignore
    * Docker **RUN** allows to run commands inside container
      * executes a command, output is added as layer in file system
* compare sdk vs runtime vs final app image
  * `docker images | grep dotnet`

* Build
* `docker build --file ./Dockerfile --no-cache --tag dotnetapp:0.1 .`
  * vscode docker extension provides handy commands to build and run images
    * Build one more time to show caching and tagging e.g 1.0
    * "Dotnet Images: Inspect"
      * see `ContainerConfig`
* Open *Docker Dashboard* and show image history
  * explain layers and how layer cache invalidation works
    * this is why we want to put more volatile stuff at the end.

* Open external terminal and login to WSL.
* `docker build .`
  * anonymous image / dangling images
  * `docker images --all --filter=dangling=true`
    * if you don't specify tag, it is hard to use image, but it is still used in caching
  * `docker image inspect <id> | jq '.[0].Id, .[0].RepoTags'`

* build image and run
  * `docker build -t dotnetapp:1.1 .`
  * `docker images dotnetapp`
  * `docker run --rm dotnetapp Docker+DotnetCore`

* Make some changes to 'Program.cs'
  * Change `GetBot()` to `RomanticProfile.GetProfile()`.

* build image and run
  * `docker build -t dotnetapp:2.0 .`
  * `docker images dotnetapp`
  * `docker run --rm dotnetapp Docker+DotnetCore`

As you can see, it is easy to create a container, but at some point of time you can see that images and containers take some space, let's see:

* `docker system info`
* `docker system df`
* ! `docker system prune`

## Takeaways

* Build containers to be reusable and configurable
  * containers should be ephemeral, lean, and disposable
* Don't forget the .dockerignore
* Don't use unnecessary packages, you don't need test editor inside database instance
* Every docker images should have only one concern and reason to change
  * container could be though of a process
  * Separation of Concerns in practice
* Minimize the number of layers
* Use multi-stage builds

## complexapp

* Explain project structure
* Show how multiple projects are added to dockerfile
  * the benefits of having different layers is caching
* Run
  * `docker run complexapp` OR
  * "Docker Images: Run Interactive"
* explain Optional ENTRYPOINT
* `docker build --pull --target test -t complexapp-test .`
* `docker volume create test-volue`
  * Go to vscode and inspect volume
  * probably vscode creates another image to connect to named volume and connects in as vscode remote
    * after that is is possible to image created by vscode
  
* Let's run some test, not that the container that was responsible for running tests is remove and tests results are stored in a named volume
* `docker run --rm --mount 'type=volume,src=test-volume,dst=/source/tests/TestResults' complexapp-test`
* `docker cp <id>:/volume/* ./TestResults`
* Go to `Foo.cs` and show code coverage
  * "Coverage gutters: Watch"
  * replace path with path (dirty fix)
    * `/source/libfoo/Foo.cs` to `libfoo/Foo.cs`
    * `sed -i 's/\/source\///g' ./TestResults/volume/lcov.info`

## Reference

* <https://docs.docker.com/engine/reference/builder/>
* <https://docs.docker.com/develop/develop-images/dockerfile_best-practices/#dockerfile-instructions>
