using CloudStructures;

namespace RedisServerWrapper {
    public class RedisServer {
        public RedisConnection Connection { get; }

        public RedisServer(RedisSettings redisSettings) =>
            Connection = new(new(redisSettings.InstanceName, redisSettings.ConnectionString, redisSettings.DatabaseId));
    }
}
