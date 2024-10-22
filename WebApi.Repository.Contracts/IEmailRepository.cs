using Model;

namespace WebApi.Contracts
{
    public interface IEmailRepository
    {
        public Task<Email?> GetEmailContent(Guid id, bool trackChanges);
    }
}
