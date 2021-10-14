using CloudStructures;
using System;

namespace RedisServerWrapper {
    public class RedisServer {
        public RedisConnection Connection { get; }

        public RedisServer(RedisSettings redisSettings) {
            if (redisSettings is null) {
                throw new ArgumentNullException(nameof(redisSettings));
            }

            Connection = new(new(redisSettings.InstanceName, redisSettings.ConnectionString));
        }


    }
}
