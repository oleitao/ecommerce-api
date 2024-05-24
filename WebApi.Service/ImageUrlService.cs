using WebApi.Contracts;
using WebApi.Service.Contracts;

namespace WebApi.Service
{
    internal sealed class ImageUrlService : IImageUrlService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ImageUrlService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}