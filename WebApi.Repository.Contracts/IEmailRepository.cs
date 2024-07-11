using Model;

namespace WebApi.Contracts
{
    public interface IEmailRepository
    {
        #region Async

        Task<Email?> GetEmailContent(Guid id, bool trackChanges);

        #endregion
    }
}
