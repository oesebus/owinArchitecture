using System;
using NLog;
using Product.Interface;
using Product.Service;
using StructureMap;
namespace Kenzardi.Core
{
	public class CoreRegistry : Registry
	{
		public CoreRegistry()
		{
			For<IProduct>().Use<ProductService>();

		}
	}
}
