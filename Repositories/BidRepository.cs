
using System.Collections.Generic;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class BidRepository : IRepository<Bids>
    {
        private readonly PoseidonDBContext _dbContext;

        public BidRepository(PoseidonDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Bids Get(int id)
        {
            Bids bid = _dbContext.Bids.Find(id);
            return bid;
        }

        public IEnumerable<Bids> GetAll()
        {
            IEnumerable<Bids> bids = _dbContext.Bids;
            return bids;
        }

        public void Save(Bids bids)
        {
            _dbContext.Add(bids);
            _dbContext.SaveChanges();
        }

        public void Update(Bids bidsUpdate)
        {
            _dbContext.Bids.Update(bidsUpdate);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Bids bid = _dbContext.Bids.Find(id);
            _dbContext.Remove(bid);
        }
    }
}
