using AutoMapper;
using WebApi.Repositories;
using WebApi.Dtos;
using WebApi.Models;
using System.Collections.Generic;

namespace WebApi.Services
{
    public class RatingService : IService<RatingDTO>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Ratings> _ratingRepository;

        public RatingService(IRepository<Ratings> ratingRepository, IMapper mapper)
        {
            _ratingRepository = ratingRepository;
            _mapper = mapper;
        }

        public RatingDTO Get(int id)
        {
            Ratings rating = _ratingRepository.Get(id);
            RatingDTO dto = _mapper.Map<RatingDTO>(rating);
            return dto;
        }

        public IEnumerable<RatingDTO> GetAll()
        {
            List<RatingDTO> dtos = new List<RatingDTO>();
            IEnumerable<Ratings> ratings = _ratingRepository.GetAll();
            foreach (Ratings r in ratings)
            {
                RatingDTO dto = _mapper.Map<RatingDTO>(r);
                dtos.Add(dto);
            }

            return dtos;
        }

        public void Save(RatingDTO dto)
        {
            Ratings rating = _mapper.Map<Ratings>(dto);
            _ratingRepository.Save(rating);
        }

        public void Update(RatingDTO dto)
        {
            Ratings rating = _mapper.Map<Ratings>(dto);
            _ratingRepository.Update(rating);
        }

        public void Delete(int id)
        {
            _ratingRepository.Delete(id);
        }
    }
}
