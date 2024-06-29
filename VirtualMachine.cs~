using System;

namespace SimpleOs{
	public class VirtualMachine{
		private byte[] memory;
		private int memorySize;
		private MemoryManager memoryManager;
		private ProcessManager processManager;
	
		public VirtualMachine(int memorySize){
			this.memorySize = memorySize;
			memory = new byte[memorySize];
			memoryManager = new(memory);
			processManager = new();
		}

		public void Initialize(){
			Console.WriteLine($"Virtual Machine Intialized with: {memorySize} bytes of memory");
		}

		public void Run(){
			Console.WriteLine("Virtual Machine running...");
			Bootloader();
		}

		public void Bootloader(){
			Console.WriteLine("Bootloader: Loading the kernel...");
			Kernel();
		}

		private void Kernel(){
			Console.WriteLine("Kernel: OS is running!");

			Console.WriteLine("Kernel: Creating a process...");
			int processId = processManager.CreateProcess(() => {
				Console.WriteLine("Process: Running task...");
				
				for(int i = 0; i < 3; i ++){
					Console.WriteLine($"Process: Task itteration {i}");
				}		
			});
			
			// run sample process
			Console.WriteLine("Kernel: Running process...");
			processManager.RunProcess(processId);

			// kill sample process
			Console.WriteLine("Kernel: Killing process");
			processManager.KillProcess(processId);

		}


	}
}
