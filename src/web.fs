namespace AsanaProxy

open System
open Microsoft.AspNetCore
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.DependencyInjection
open Giraffe

module Web =
    let itemHandler (workspace : string) : HttpHandler =
        fun (_ : HttpFunc) (ctx : HttpContext) ->
            match ctx.TryGetQueryStringValue "pat" with
            | Some pat -> ctx.WriteJsonAsync (Asana.getWorkspaceTasks pat workspace)
            | None -> ctx.SetStatusCode 401
                      ctx.WriteTextAsync "missing pat"

    let endpoints =
        choose [
            route "/ping" >=> text "pong"
            routef "/items/%s" itemHandler
        ]

    (* let notFoundHandler =
        "Not Found"
        |> text
        |> RequestErrors.notFound *)

    let configureApp (appBuilder : IApplicationBuilder) =
        appBuilder
            .UseRouting()
            .UseGiraffe(endpoints)
            //.UseGiraffe(notFoundHandler)

    let configureServices (services : IServiceCollection) =
        services
            .AddRouting()
            .AddGiraffe()
        |> ignore

    let [<Literal>] BaseAddress = "0.0.0.0:8085"

    let webServer args =
        WebHost
            .CreateDefaultBuilder(args)
            .UseKestrel()
            .Configure(configureApp)
            .ConfigureServices(configureServices)
            .UseUrls(sprintf "http://%s" BaseAddress)
            .Build()
            .Run()



