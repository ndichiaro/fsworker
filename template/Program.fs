open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Logging
open System
open System.Threading.Tasks

type Worker (logger:ILogger<Worker>) =
    inherit BackgroundService()

    override this.ExecuteAsync (stoppingToken: System.Threading.CancellationToken) =
        async {
            while not stoppingToken.IsCancellationRequested do
                logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now)
                do! Async.Sleep 1000
        }
        |> Async.StartAsTask :> Task

module HostingWrapper =
    let configureService (hostBuilder:IHostBuilder) =
        hostBuilder.ConfigureServices (fun (hostContext:HostBuilderContext) (services:IServiceCollection) -> services.AddHostedService<Worker>() |> ignore)
    
    let build  (hostBuilder:IHostBuilder) =
        hostBuilder.Build()
    
    let run (host:IHost) =
        host.Run()

open HostingWrapper

[<EntryPoint>]
let main argv =
    Host.CreateDefaultBuilder argv
    |> configureService
    |> build
    |> run
    0 