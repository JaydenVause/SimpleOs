using System;

namespace SimpleOs{
	public class VirtualMachine{
		private byte[] memory;
		private int memorySize;
		private MemoryManager memoryManager;

		public VirtualMachine(int memorySize){
			this.memorySize = memorySize;
			memory = new byte[memorySize];
			memoryManager = new(memory);
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
			

			Console.WriteLine("Kernel: Allocating memory...");

			int address = memoryManager.Allocate(100); // allocate 100 bytes of memory

			Console.WriteLine("Kernel: Using allocated memory");

			//free up memory
			Console.WriteLine("Kernel: Freeing memory...");
			memoryManager.Free(address, 100);
		}


	}
}
