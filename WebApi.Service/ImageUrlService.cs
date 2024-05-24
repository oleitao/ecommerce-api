using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.Models;
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

        public IEnumerable<ImageUrl> GetAllImageUrls(bool trackChanges)
        {
            try
            {
                var images = _repository.ImageUrl.GetImageUrls(trackChanges);
                return images;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllImageUrls)} service method {ex}");
                throw;
            }
        }

        public ImageUrl GetImageUrl(Guid id, bool trackChanges)
        {
            try
            {
                var image = _repository.ImageUrl.GetImageUrl(id, trackChanges);
                if (image == null)
                    throw new ImageUrlNotFoundException(id);

                return image;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetImageUrl)} service method {ex}");
                throw;
            }
        }
    }
}