using AutoMapper;
using WebApi.Repositories;
using WebApi.Dtos;
using WebApi.Models;
using System.Collections.Generic;

namespace WebApi.Services
{
    public class BidService : IService<BidDTO>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Bids> _bidsRepository;

        public BidService(IRepository<Bids> bidsRepository, IMapper mapper)
        {
            _bidsRepository = bidsRepository;
            _mapper = mapper;
        }

        public BidDTO Get(int id)
        {
            Bids bids = _bidsRepository.Get(id);
            BidDTO dto = _mapper.Map<BidDTO>(bids);
            return dto;
        }

        public IEnumerable<BidDTO> GetAll()
        {
            List<BidDTO> dtos = new List<BidDTO>();
            IEnumerable<Bids> bids = _bidsRepository.GetAll();
            foreach (Bids b in bids)
            {
                BidDTO dto = _mapper.Map<BidDTO>(b);
                dtos.Add(dto);
            }

            return dtos;
        }

        public void Save(BidDTO dto)
        {
            Bids bid = _mapper.Map<Bids>(dto);
            _bidsRepository.Save(bid);
        }

        public void Update(BidDTO dto)
        {
            Bids bid = _mapper.Map<Bids>(dto);
            _bidsRepository.Update(bid);
        }

        public void Delete(int id)
        {
            _bidsRepository.Delete(id);
        }
    }
}
