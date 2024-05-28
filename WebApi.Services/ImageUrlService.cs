using AutoMapper;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
using WebApi.Entities.Models;
using WebApi.Service.Contracts;
using WebApi.Shared.DataTransferObjects;

namespace WebApi.Services
{
    internal sealed class ImageUrlService : IImageUrlService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public ImageUrlService(IRepositoryManager repository, ILoggerManager logger, AutoMapper.IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
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

        public ImageUrlDto CreateImageUrl(ImageUrlForCreationDto imageUrl)
        {
            var imageUrlEntity = _mapper.Map<ImageUrl>(imageUrl);

            _repository.ImageUrl.CreateImageUrl(imageUrlEntity);
            _repository.Save();

            var imageUrlReturn = _mapper.Map<ImageUrlDto>(imageUrlEntity);

            return imageUrlReturn;
        }

        public void DeleteImageUrl(Guid id, bool trackChanges)
        {
            var imageUrl = _repository.ImageUrl.GetImageUrl(id, trackChanges: false);
            if (imageUrl is null)
                throw new Exception();

            _repository.ImageUrl.DeleteImageUrl(imageUrl);
            _repository.Save();
        }
    }
}