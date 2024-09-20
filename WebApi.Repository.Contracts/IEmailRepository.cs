using Model;

namespace WebApi.Contracts
{
    public interface IEmailRepository
    {
        #region Async

        public Task<Email?> GetEmailContent(Guid id, bool trackChanges);

        #endregion
    }
}
