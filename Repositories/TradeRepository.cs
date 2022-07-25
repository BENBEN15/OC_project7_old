using System.Collections.Generic;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class TradeRepository : IRepository<Trades>
    {
        private readonly PoseidonDBContext _dbContext;

        public TradeRepository(PoseidonDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Trades Get(int id)
        {
            Trades trade = _dbContext.Trades.Find(id);
            return trade;
        }

        public IEnumerable<Trades> GetAll()
        {
            IEnumerable<Trades> trades = _dbContext.Trades;
            return trades;
        }

        public void Save(Trades trade)
        {
            _dbContext.Add(trade);
            _dbContext.SaveChanges();
        }

        public void Update(Trades trade)
        {
            _dbContext.Trades.Update(trade);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Trades trade = _dbContext.Trades.Find(id);
            _dbContext.Remove(trade);
        }
    }
}
