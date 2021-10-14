namespace RedisServerWrapper {
    public record RedisSettings {
        public string ConnectionString { get; init; } = string.Empty;

        public string InstanceName { get; init; } = string.Empty;

        public int DatabaseId { get; init; } = 0;
    }
}
