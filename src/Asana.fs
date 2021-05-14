namespace AsanaProxy

open FSharp.Data

module Asana =
    type WorkspaceList = JsonProvider<"""{ "data":[
        { "gid":"9096079123990", "name":"itu.dk", "resource_type":"workspace" },
        { "gid":"1200120396557484", "name":"CFIX - ITU Project", "resource_type":"workspace" }
    ] }""">
    type WorkspaceProjectList = JsonProvider<"""{
      "data": [
        { "gid": "1200168538701148","name": "Backlog", "resource_type": "project" },
        { "gid": "1200163629839671","name": "Sprint 1", "resource_type": "project" }
      ]
    }""">
    type ProjectTaskList = JsonProvider<"""{
      "data": [
        { "gid": "1200162263566988", "name": "SRINT GOAL 3: Complete Deployment Pipeline",
          "resource_type": "task"
        },
        { "gid": "1200159073967066",
          "name": "As an employee, I can query across projects included in Hobbes with a specific sprint, so that I can analyze sprints",
          "resource_type": "task"
        }
      ]
    }""">
    type ProjectTasks = JsonProvider<"""[{
      "data": {
        "gid": "1200157973471618",
        "assignee": null,
        "assignee_status": "upcoming",
        "completed": true,
        "completed_at": "2021-05-05T11:10:03.247Z",
        "created_at": "2021-04-06T12:45:21.269Z",
        "custom_fields": [
          {
            "gid": "1200158027798200",
            "enabled": true,
            "enum_options": [
              {
                "gid": "1200158027798201",
                "color": "red",
                "enabled": true,
                "name": "High",
                "resource_type": "enum_option"
              }
            ],
            "enum_value": null,
            "name": "Priority",
            "created_by": {
              "a": "a",
              "gid": "1199878836246086",
              "name": "[SM] Petya Buchkova",
              "resource_type": "user"
            },
            "display_value": null,
            "resource_subtype": "enum",
            "resource_type": "custom_field",
            "type": "enum"
          }
        ],
        "due_at": null,
        "due_on": null,
        "followers": [
          {
            "b": "b",
            "gid": "1199878836246086",
            "name": "[SM] Petya Buchkova",
            "resource_type": "user"
          }
        ],
        "hearted": false,
        "hearts": [],
        "liked": false,
        "likes": [],
        "memberships": [
          {
            "project": {
              "gid": "1200120464423346",
              "name": "Sprint 3",
              "resource_type": "project"
            },
            "section": {
              "gid": "1200120464423354",
              "name": "Done",
              "resource_type": "section"
            }
          }
        ],
        "modified_at": "2021-05-05T11:10:03.351Z",
        "name": "GraphQL for existing data in Hobbes - 13 Story Points",
        "notes": "    Create build pipeline\n    Create deployment\n    Create a container with a service endpoint\n    Change Kubernetes deployment to include new container\n    Implement querying\n    Should we have an indexing service?\n    Changes to existing data format to include metadata (searchable tags and type for GQL)\n",
        "num_hearts": 0,
        "num_likes": 0,
        "parent": null,
        "permalink_url": "https://app.asana.com/0/1200120464423346/1200157973471618",
        "projects": [
          {
            "gid": "1200120464423346",
            "name": "Sprint 3",
            "resource_type": "project"
          }
        ],
        "resource_type": "task",
        "start_on": null,
        "tags": [],
        "resource_subtype": "milestone",
        "workspace": {
          "gid": "1200120396557484",
          "name": "CFIX - ITU Project",
          "resource_type": "workspace"
        }
      }
    },{
      "data": {
        "gid": "1200157973471618",
        "assignee": null,
        "assignee_status": "upcoming",
        "completed": true,
        "completed_at": null,
        "created_at": "2021-04-06T12:45:21.269Z",
        "custom_fields": [
          {
            "gid": "1200158027798200",
            "enabled": true,
            "enum_options": [
              {
                "gid": "1200158027798201",
                "color": "red",
                "enabled": true,
                "name": "High",
                "resource_type": "enum_option"
              }
            ],
            "enum_value": null,
            "name": "Priority",
            "created_by": {
              "a": "a",
              "gid": "1199878836246086",
              "name": "[SM] Petya Buchkova",
              "resource_type": "user"
            },
            "display_value": null,
            "resource_subtype": "enum",
            "resource_type": "custom_field",
            "type": "enum"
          }
        ],
        "due_at": null,
        "due_on": null,
        "followers": [
          {
            "b": "b",
            "gid": "1199878836246086",
            "name": "[SM] Petya Buchkova",
            "resource_type": "user"
          }
        ],
        "hearted": false,
        "hearts": [],
        "liked": false,
        "likes": [],
        "memberships": [
          {
            "project": {
              "gid": "1200120464423346",
              "name": "Sprint 3",
              "resource_type": "project"
            },
            "section": {
              "gid": "1200120464423354",
              "name": "Done",
              "resource_type": "section"
            }
          }
        ],
        "modified_at": "2021-05-05T11:10:03.351Z",
        "name": "GraphQL for existing data in Hobbes - 13 Story Points",
        "notes": "    Create build pipeline\n    Create deployment\n    Create a container with a service endpoint\n    Change Kubernetes deployment to include new container\n    Implement querying\n    Should we have an indexing service?\n    Changes to existing data format to include metadata (searchable tags and type for GQL)\n",
        "num_hearts": 0,
        "num_likes": 0,
        "parent": null,
        "permalink_url": "https://app.asana.com/0/1200120464423346/1200157973471618",
        "projects": [
          {
            "gid": "1200120464423346",
            "name": "Sprint 3",
            "resource_type": "project"
          }
        ],
        "resource_type": "task",
        "start_on": null,
        "tags": [],
        "resource_subtype": "milestone",
        "workspace": {
          "gid": "1200120396557484",
          "name": "CFIX - ITU Project",
          "resource_type": "workspace"
        }
      }
    }]""", SampleIsList=true>

    type FlatTask = {
        ProjectName : string
        CreatedDate : string
        SprintName  : string
        ClosedDate  : string
        Title       : string
    }

    let baseURL = "https://app.asana.com/api/1.0/"

    let requestToErrorMessage r =
        let msg = match r.Body with
                  | Text text -> text
                  | Binary bytes -> "[binary data]"
        sprintf "%d: %s\n" r.StatusCode msg

    let getWorkspaceProjects pat workspaceGID =
        printfn "Requestion for getWorkspaceProjects %s" workspaceGID
        let r = Http.Request ( baseURL + "workspaces/" + workspaceGID + "/projects",
                               headers = [ "Authorization", "Bearer " + pat ])
        if r.StatusCode <> 200 then
            raise (System.Exception (requestToErrorMessage r))
        else
            match r.Body with
            | Text text -> WorkspaceProjectList.Parse text
            | Binary bytes -> WorkspaceProjectList.Parse (bytes.ToString ()) // Unsure if works or needed

    let getProjectTasks pat projectGID =
        printfn "Requestion for getProjectTasks %s" projectGID
        let r = Http.Request ( baseURL + "projects/" + projectGID + "/tasks",
                               headers = [ "Authorization", "Bearer " + pat ])
        if r.StatusCode <> 200 then
            raise (System.Exception (requestToErrorMessage r))
        else
            match r.Body with
            | Text text -> ProjectTaskList.Parse text
            | Binary bytes -> ProjectTaskList.Parse (bytes.ToString ())

    let getTaskExpanded pat taskGID =
        printfn "Requestion for getTaskExpanded %s" taskGID
        let r = Http.Request ( baseURL + "tasks/" + taskGID,
                               headers = [ "Authorization", "Bearer " + pat ])
        if r.StatusCode <> 200 then
            raise (System.Exception (requestToErrorMessage r))
        else
            match r.Body with
            | Text text -> ProjectTasks.Parse text
            | Binary bytes -> ProjectTasks.Parse (bytes.ToString ())

    let getWorkspaceTasks pat workspaceGID =
        (getWorkspaceProjects pat workspaceGID).Data 
            |> Seq.fold (fun acc project -> Array.append acc (getProjectTasks pat (string project.Gid)).Data) Array.empty
            |> Seq.fold (fun acc smallTask -> List.append acc [(getTaskExpanded pat (string smallTask.Gid))]) []
            //|> Seq.map (fun task -> task.Data)
            |> Seq.map (fun task -> { Title = task.Data.Name
                                      ProjectName = task.Data.Workspace.Name
                                      CreatedDate = task.Data.CreatedAt.ToString ()
                                      ClosedDate  = match task.Data.CompletedAt with
                                                    | Some date -> date.ToString ()
                                                    | None -> ""
                                      //SprintName  = Seq.head data.Projects |> fun a -> a.Name
                                      SprintName  = Seq.fold (fun acc (p : ProjectTasks.Project) ->
                                        if p.ResourceType = "project" then p.Name else acc) "" task.Data.Projects
                                    })

            


