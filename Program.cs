﻿using System;

namespace SimpleOs{
	class Program{
		static void Main(string[] args){
			int memorySize = 1024 * 1024; // 1MB of memory
			VirtualMachine vm = new(memorySize);
			vm.Initialize();
			vm.Run();
		}
	}
}
