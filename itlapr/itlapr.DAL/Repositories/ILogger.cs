namespace itlapr.DAL.Repositories
{
    internal interface ILogger<T>
    {
        void logError(string v1, Exception ex, string? v2);
    }
}