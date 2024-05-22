using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Users;

namespace WebApi.Services
{
    public class ImageUrlService : IImageUrlService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public ImageUrlService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ImageUrl> GetAll()
        {
            return _context.ImageUrls.ToList();
        }

        public ImageUrl GetById(int id)
        {
            return getImageUrl(id);
        }

        public void Create(CreateImageURLRequest model)
        {
            // map model to new image_url object
            var image_url = _mapper.Map<ImageUrl>(model);

            // save image_url
            _context.ImageUrls.Add(image_url);
            _context.SaveChanges();
        }

        public void Update(int id, UpdateImageURLRequest model)
        {
            var image_url = getImageUrl(id);

            // copy model to image_url and save
            _mapper.Map(model, image_url);
            _context.ImageUrls.Update(image_url);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var image_url = getImageUrl(id);
            _context.ImageUrls.Remove(image_url);
            _context.SaveChanges();
        }

        // helper methods

        private ImageUrl getImageUrl(int id)
        {
            var image_url = _context.ImageUrls.Find(id);
            if (image_url == null) throw new KeyNotFoundException("ImageUrl not found");
            return image_url;
        }
    }
}
