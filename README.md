# FS Worker

## Overview

A custom template for `dotnet new` to create a new F# worker service project. 

[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/Template.Worker.FSharp)](https://www.nuget.org/packages/Tools.Net.Mongo)

## Installing the template

To install fsworker, use the [dotnet new -i|--install](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new) command

`dotnet new --install Template.Worker.FSharp`

To install a specific version use `::` followed by the desired version

`dotnet new --install Template.Worker.FSharp::1.0.0`

## Using the template

To create a project using the fsworker worker, use the [dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new) command and specify `fsworker` as the template

`dotnet new fsworker`

By default, a project will be created using the name of the directory `dotnet new` was executed in. To specify the project name use the [-n|--name](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new) option

`dotnet new fsworker -n Demo.FSharp.Worker`
