using System;

namespace SimpleOs{
	public class MemoryManager{
		private byte[] memory;

		public MemoryManager(byte[] memory){
			this.memory = memory;
		}

		public int Allocate(int size){
			for(int i = 0; i < memory.Length - size; i++){
				bool isFree = true;

				for(int j = 0; j < size; j++){
					if(memory[i + j] != 0){
						isFree = false;
						break;
					}
				}
				 
				if(isFree){
					for(int j = 0; j<size; j++){
						memory[i + j] = 1; // mark as allocated
					}

					Console.WriteLine($"MemoryManager: Allocated {size} bytes at address {i}");
					return i;
				}
			}

			throw new OutOfMemoryException($"Not enough memory to allocate {size} bytes");
		}

		public void Free(int address, int size){
			// simple deallocation logic
			for(int i = 0; i < size; i++){
				memory[address + i] = 0;
			}
			Console.WriteLine($"MemoryManager: Freed {size} bytes at address {address}");
		}
	}
}
