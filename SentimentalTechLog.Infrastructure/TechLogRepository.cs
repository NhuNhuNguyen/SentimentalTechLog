using SentimentalTechLog.Domain;
namespace SentimentalTechLog.Infrastructure;

public class TechLogRepository : ITechLogRepository
{
    private readonly List<TechLog> _techLogs = new();

    public Task<TechLog?> GetTechLogByIdAsync(Guid id)
    {
        return Task.FromResult(_techLogs.FirstOrDefault(t => t.Id == id));
    }

    public Task<List<TechLog>> GetAllTechLogsAsync()
    {
        return Task.FromResult(_techLogs);
    }

    public Task AddTechLogAsync(TechLog techLog)
    {
        _techLogs.Add(techLog);
        return Task.CompletedTask;
    }

}
