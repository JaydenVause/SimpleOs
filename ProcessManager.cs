using System;
using System.Collections.Generic;

namespace SimpleOs{
	public class Process{
		public int Id {get;}
		public Action Task {get;}
		public bool Finished;

		public Process(int id, Action task){
			Id = id;
			Task = task;
		}

		public void Run(){
			Task();
		}
	}

	public class ProcessManager{
		private List<Process> processes = new();
		private int nextProcessId = 1;

		public int CreateProcess(Action task){
			var process = new Process(nextProcessId++, task);
			processes.Add(process);
			return process.Id;
		}

		public void RunProcess(int id){
			var process = processes.Find(p => p.Id == id);
			if(process != null){
				Console.WriteLine($"ProcessManager: Runnning process {process.Id}");
				process.Run();
			}else{
				Console.WriteLine($"ProcessManager: Process {id} not found");
			}
		}

		public void KillProcess(int id){
			var process = processes.Find(p => p.Id == id);

			if(process != null){
				processes.Remove(process);
				Console.WriteLine($"ProcessManager: Killed process {id}");
			}else{
				Console.WriteLine($"ProcessManager: Process {id} not found");
			}
		}
		

		public void RunAllProcesses(){
		
			int processIndex = 0;

			while(processes.Count > 0){
				
				var process = processes[processIndex];
				if(!process.Finished){
					Console.WriteLine($"ProcessManager: Running process {process.Id}");
					process.Run();
				}else{
				
					processes.RemoveAt(processIndex);
					processIndex--;
				}

				processIndex = (processIndex + 1) % processes.Count;
				
			}
		}
	}
}
