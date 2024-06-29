using System;

namespace SimpleOs{
	public class VirtualMachine{
		private byte[] memory;
		private int memorySize;
		private MemoryManager memoryManager;
		private ProcessManager processManager;
	
		public VirtualMachine(int memorySize){
			this.memorySize = memorySize; // define memory for machine
			memory = new byte[memorySize]; // give memorySize amounts of bites to this instances memory
			memoryManager = new(memory); // create a new MemoryManager to handle memory
			processManager = new(); // create a new ProcessManager to handle process's
		}

		public void Initialize(){
			Console.WriteLine($"Virtual Machine Intialized with: {memorySize} bytes of memory");
		}

		public void Run(){
			Console.WriteLine("Virtual Machine running...");
			Bootloader(); // bootloader responsible for loading OS into memory and starting it
		}

		public void Bootloader(){
			Console.WriteLine("Bootloader: Loading the kernel...");
			Kernel(); // Core of the OS handles process management, memory management and I/O operations
		}

		private void Kernel(){
			Console.WriteLine("Kernel: OS is running!");

			Console.WriteLine("Kernel: Creating a process...");
			processManager.CreateProcess(()=>{Console.WriteLine("HelloWorld");});
			processManager.CreateProcess(()=>{Console.WriteLine("GOODBYEWorld");});


			processManager.RunAllProcesses();
		}


	}
}
