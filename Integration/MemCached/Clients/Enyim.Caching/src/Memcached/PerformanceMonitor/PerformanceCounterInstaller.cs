// Copyright (c) 2017 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Enyim.Caching.Memcached
{
	[System.ComponentModel.RunInstaller(true)]
	public class PerformanceCounterInstaller : System.Diagnostics.PerformanceCounterInstaller
	{
		public PerformanceCounterInstaller()
		{
			this.CategoryName = DefaultPerformanceMonitor.CategoryName;
			this.CategoryType = PerformanceCounterCategoryType.MultiInstance;
			this.UninstallAction = System.Configuration.Install.UninstallAction.Remove;

			// Get
			this.Counters.AddRange(DefaultPerformanceMonitor.OpMonitor.CreateCounters(DefaultPerformanceMonitor.Names.Get));
			this.Counters.AddRange(DefaultPerformanceMonitor.OpMonitor.CreateCounters(DefaultPerformanceMonitor.Names.Set));
			this.Counters.AddRange(DefaultPerformanceMonitor.OpMonitor.CreateCounters(DefaultPerformanceMonitor.Names.Add));
			this.Counters.AddRange(DefaultPerformanceMonitor.OpMonitor.CreateCounters(DefaultPerformanceMonitor.Names.Replace));
			this.Counters.AddRange(DefaultPerformanceMonitor.OpMonitor.CreateCounters(DefaultPerformanceMonitor.Names.Delete));
			this.Counters.AddRange(DefaultPerformanceMonitor.OpMonitor.CreateCounters(DefaultPerformanceMonitor.Names.Increment));
			this.Counters.AddRange(DefaultPerformanceMonitor.OpMonitor.CreateCounters(DefaultPerformanceMonitor.Names.Decrement));
			this.Counters.AddRange(DefaultPerformanceMonitor.OpMonitor.CreateCounters(DefaultPerformanceMonitor.Names.Append));
			this.Counters.AddRange(DefaultPerformanceMonitor.OpMonitor.CreateCounters(DefaultPerformanceMonitor.Names.Prepend));
		}
	}
}
