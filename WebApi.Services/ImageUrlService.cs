﻿using AutoMapper;
using Model;
using WebApi.Contracts;
using WebApi.Entities.Exceptions;
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

        #region Sync

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

        #endregion

        #region Async

        public async Task<IEnumerable<ImageUrl>> GetAllImageUrlsAsync(bool trackChanges)
        {
            try
            {
                var images = await _repository.ImageUrl.GetImageUrlsAsync(trackChanges);
                return images;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllImageUrlsAsync)} service method {ex}");
                throw;
            }
        }

        public async Task<ImageUrl> GetImageUrlAsync(Guid id, bool trackChanges)
        {
            try
            {
                var image = await _repository.ImageUrl.GetImageUrlAsync(id, trackChanges);
                if (image == null)
                    throw new ImageUrlNotFoundException(id);

                return image;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetImageUrlAsync)} service method {ex}");
                throw;
            }
        }

        public async Task<ImageUrlDto> CreateImageUrlAsync(ImageUrlForCreationDto imageUrlDto)
        {
            var imageUrlEntity = _mapper.Map<ImageUrl>(imageUrlDto);

            if(imageUrlEntity.Id == Guid.Empty)
                imageUrlEntity.Id = Guid.NewGuid();

            _repository.ImageUrl.CreateImageUrl(imageUrlEntity);
            await _repository.SaveAsync();

            var imageUrlReturn = _mapper.Map<ImageUrlDto>(imageUrlEntity);

            return imageUrlReturn;
        }

        public async Task DeleteImageUrlAsync(Guid id, bool trackChanges)
        {
            var imageUrl = await _repository.ImageUrl.GetImageUrlAsync(id, trackChanges: false);
            if (imageUrl is null)
                throw new Exception();

            _repository.ImageUrl.DeleteImageUrl(imageUrl);
            await _repository.SaveAsync();
        }

        public Task UpdateImageUrlAsync(int id, ImageUrlForUpdateDto imageUrl, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}