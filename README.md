# Test-21-February
update home task


| HTTP-request |                        Endpoint                                     |            Description                     | Checking |
| -------------|:-------------------------------------------------------------------:| ------------------------------------------:|---------
| GET          | https://mydomain.testmonitor.com/api/v1/projects/{projectId}        | Retrieve a single project                  |Verify that project was retrieved successfully|
| POST         | https://mydomain.testmonitor.com/api/v1/project/{projectId}/archive | Archive a project                          |
| GET          | https://mydomain.testmonitor.com/api/v1/issues/{issueId}            | Retrieve a single issue                    |                 
| POST         | https://mydomain.testmonitor.com/api/v1/issues                      | Create an issue                            |
| GET          | https://mydomain.testmonitor.com/api/v1/requirements/{requirementId}| Retrieve a requirement using its identifier|
