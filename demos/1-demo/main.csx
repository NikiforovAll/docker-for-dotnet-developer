// docker container run -it --rm --mount type=bind,source="C:\\Nikiforov\\dev\\docker-for-dotnet-dev\\demos\\1-demo",target=/scripts,readonly --workdir=/scripts --name dnscript 587 main.csx -- Oleksii
Console.Write($"Hello, {Args[0]}!");
Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\t[from .csx script written on C#]");
