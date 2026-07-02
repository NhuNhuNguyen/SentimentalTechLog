namespace SentimentalTechLog.Domain;
public interface ITechLogRepository
{
    Task<TechLog?> GetTechLogByIdAsync(Guid id);
    Task<List<TechLog>> GetAllTechLogsAsync();
    Task AddTechLogAsync(TechLog techLog);
}