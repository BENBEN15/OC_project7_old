using AutoMapper;
using WebApi.Repositories;
using WebApi.Dtos;
using WebApi.Models;
using System.Collections.Generic;

namespace WebApi.Services
{
    public class TradeService : IService<TradeDTO>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Trades> _tradesRepository;

        public TradeService(IRepository<Trades> tradesRepository, IMapper mapper)
        {
            _tradesRepository = tradesRepository;
            _mapper = mapper;
        }

        public TradeDTO Get(int id)
        {
            Trades trade = _tradesRepository.Get(id);
            TradeDTO dto = _mapper.Map<TradeDTO>(trade);
            return dto;
        }

        public IEnumerable<TradeDTO> GetAll()
        {
            List<TradeDTO> dtos = new List<TradeDTO>();
            IEnumerable<Trades> trades = _tradesRepository.GetAll();
            foreach (Trades t in trades)
            {
                TradeDTO dto = _mapper.Map<TradeDTO>(t);
                dtos.Add(dto);
            }

            return dtos;
        }

        public void Save(TradeDTO dto)
        {
            Trades trade = _mapper.Map<Trades>(dto);
            _tradesRepository.Save(trade);
        }

        public void Update(TradeDTO dto)
        {
            Trades trade = _mapper.Map<Trades>(dto);
            _tradesRepository.Update(trade);
        }

        public void Delete(int id)
        {
            _tradesRepository.Delete(id);
        }
    }
}
