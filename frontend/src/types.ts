type Task = {
  id: number,
  title: string,
  isCompleted: boolean
}

export type TodoType = {
  id: number,
  title: string,
  tasks: Task[]
}