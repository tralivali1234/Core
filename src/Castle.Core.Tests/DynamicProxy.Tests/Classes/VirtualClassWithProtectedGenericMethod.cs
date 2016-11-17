﻿// Copyright 2004-2010 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.DynamicProxy.Tests.Classes
{
	public class VirtualClassWithProtectedGenericMethod
	{
		private readonly int result;

		public VirtualClassWithProtectedGenericMethod(int result)
		{
			this.result = result;
		}

		public VirtualClassWithProtectedGenericMethod()
		{
		}

		protected virtual T Method<T>()
		{
			if(typeof(T)!=typeof(int))
			{
				return default(T);
			}
			return (T)(object)result;
		}

		public virtual T PublicMethod<T>()
		{
			return Method<T>();
		}
	}
}