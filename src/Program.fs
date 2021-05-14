namespace AsanaProxy

open System

module Program =
    let from whom =
        sprintf "from %s" whom

    [<EntryPoint>]
    let main argv =
        (Asana.getWorkspaceTasks argv.[0] argv.[1])
        |> Seq.map (fun task -> sprintf "%s - %s - %s - %s - %s\n" task.Title task.ProjectName task.SprintName task.ClosedDate task.SprintName)
        //|> Seq.map (fun task -> sprintf "%A\n" task)
        |> Seq.fold (fun acc e -> acc + e) ""
        |> printf "%A"
        0 // return an integer exit code