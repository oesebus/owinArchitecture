using System;
using StackExchange.Redis;
using StructureMap;

namespace Registries
{
	public class RedisRegistry : Registry
	{
		public RedisRegistry(string redisServerHost)
		{
			if (string.IsNullOrEmpty(redisServerHost))
				throw new ArgumentNullException();

			//StackExchange.Redis
			ConnectionMultiplexer multiplexer = ConnectionMultiplexer.Connect(redisServerHost);
			For<IConnectionMultiplexer>().Use(multiplexer);
		}
	}
}
