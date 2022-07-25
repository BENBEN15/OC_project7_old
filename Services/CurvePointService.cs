using AutoMapper;
using WebApi.Repositories;
using WebApi.Dtos;
using WebApi.Models;
using System.Collections.Generic;

namespace WebApi.Services
{
    public class CurvePointService : IService<CurvePointDTO>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<CurvePoints> _cpRepository;

        public CurvePointService(IRepository<CurvePoints> cpRepository, IMapper mapper)
        {
            _cpRepository = cpRepository;
            _mapper = mapper;
        }

        public CurvePointDTO Get(int id)
        {
            CurvePoints cp = _cpRepository.Get(id);
            CurvePointDTO dto = _mapper.Map<CurvePointDTO>(cp);
            return dto;
        }

        public IEnumerable<CurvePointDTO> GetAll()
        {
            List<CurvePointDTO> dtos = new List<CurvePointDTO>();
            IEnumerable<CurvePoints> cps = _cpRepository.GetAll();
            foreach (CurvePoints cp in cps)
            {
                CurvePointDTO dto = _mapper.Map<CurvePointDTO>(cp);
                dtos.Add(dto);
            }

            return dtos;
        }

        public void Save(CurvePointDTO dto)
        {
            CurvePoints cp = _mapper.Map<CurvePoints>(dto);
            _cpRepository.Save(cp);
        }

        public void Update(CurvePointDTO dto)
        {
            CurvePoints cp = _mapper.Map<CurvePoints>(dto);
            _cpRepository.Update(cp);
        }

        public void Delete(int id)
        {
            _cpRepository.Delete(id);
        }
    }
}
