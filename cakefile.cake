#load "nuget:?package=Rocket.Surgery.Cake.Application&version=0.1.8"

Task("Default").Finally(() => { Information("hello world"); });

RunTarget(Target);
