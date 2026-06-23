# Plan 

## Basic plan (STEP-BY-STEP)
### Angular UI only (dummy data)
	- [ ] Display todo title
	- [ ] Display tasks
	- [ ] Add task
	- [ ] Toggle completion
	- [ ] Delete task
	- [ ] No backend yet
### .NET Backend
  - [ ] Create Todo and Task models
  - [ ] Implement REST APIs:
  - [ ] GET /todo
  - [ ] POST /tasks
  - [ ] PUT /tasks/{id}
  - [ ] DELETE /tasks/{id}
  - [ ] Store data in memory first (no database)
### Connect Angular ↔ .NET
  - [ ] Replace dummy data with HTTP calls
  - [ ] Use an Angular service (HttpClient)
Then move to multiple todos
Introduce Todo[]
Add CRUD for todos themselves
Nest tasks under each todo
## Data Structure (for single todo)
```js
{
  id: number,
  title: string,
  tasks: [
    {
      id: number,
      title: string,
      isCompleted: boolean
    }
  ]
}
```