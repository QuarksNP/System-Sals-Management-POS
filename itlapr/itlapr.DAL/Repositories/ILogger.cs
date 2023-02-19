namespace itlapr.DAL.Repositories
{
    public interface ILogger<T>
    {
        void logError(string v1, Exception ex, string? v2);
        void logError(string v1, string v2);
    }
}