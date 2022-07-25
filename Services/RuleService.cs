using AutoMapper;
using WebApi.Repositories;
using WebApi.Dtos;
using WebApi.Models;
using System.Collections.Generic;

namespace WebApi.Services
{
    public class RuleService : IService<RuleDTO>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Rules> _rulesRepository;

        public RuleService(IRepository<Rules> rulesRepository, IMapper mapper)
        {
            _rulesRepository = rulesRepository;
            _mapper = mapper;
        }

        public RuleDTO Get(int id)
        {
            Rules rule = _rulesRepository.Get(id);
            RuleDTO dto = _mapper.Map<RuleDTO>(rule);
            return dto;
        }

        public IEnumerable<RuleDTO> GetAll()
        {
            List<RuleDTO> dtos = new List<RuleDTO>();
            IEnumerable<Rules> rules = _rulesRepository.GetAll();
            foreach (Rules r in rules)
            {
                RuleDTO dto = _mapper.Map<RuleDTO>(r);
                dtos.Add(dto);
            }

            return dtos;
        }

        public void Save(RuleDTO dto)
        {
            Rules rules = _mapper.Map<Rules>(dto);
            _rulesRepository.Save(rules);
        }

        public void Update(RuleDTO dto)
        {
            Rules rules = _mapper.Map<Rules>(dto);
            _rulesRepository.Update(rules);
        }

        public void Delete(int id)
        {
            _rulesRepository.Delete(id);
        }
    }
}
