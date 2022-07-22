using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class RuleRepository : IRepository<Rules>
    {
        private readonly PoseidonDBContext _dbContext;

        public RuleRepository(PoseidonDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Rules Get(int id)
        {
            Rules rule = _dbContext.Rules.Find(id);
            return rule;
        }

        public IEnumerable<Rules> GetAll()
        {
            IEnumerable<Rules> rules = _dbContext.Rules;
            return rules;
        }

        public void Save(Rules rule)
        {
            _dbContext.Add(rule);
            _dbContext.SaveChanges();
        }

        public void Update(Rules rule)
        {
            _dbContext.Rules.Update(rule);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Rules rule = _dbContext.Rules.Find(id);
            _dbContext.Remove(rule);
        }
    }
}
