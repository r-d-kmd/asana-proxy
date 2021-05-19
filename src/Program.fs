namespace AsanaProxy

open System
open System.Text.RegularExpressions
module Program =
    let (|Int|_|) str =
       match System.Int32.TryParse(str : string) with
       | (true, int) -> Some(int)
       | _ -> None
    let (|String|_|) str =
       Some str
    [<EntryPoint>]
    let main argv =
        match argv.[0] with
        | Int i ->
            Web.webServer argv
        | String pat ->
            (Asana.getWorkspaceTasks pat argv.[1])
            |> Seq.map (fun task -> sprintf "%s - %s - %s - %s - %s\n" task.Title task.ProjectName task.SprintName task.ClosedDate task.SprintName)
            //|> Seq.map (fun task -> sprintf "%A\n" task)
            |> Seq.fold (fun acc e -> acc + e) ""
            |> printf "%A"
        | _ -> printfn ""
        0 // return an integer exit code