using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class RatingRepository : IRepository<Ratings>
    {
        private readonly PoseidonDBContext _dbContext;

        public RatingRepository(PoseidonDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Ratings Get(int id)
        {
            Ratings rating = _dbContext.Ratings.Find(id);
            return rating;
        }

        public IEnumerable<Ratings> GetAll()
        {
            IEnumerable<Ratings> ratings = _dbContext.Ratings;
            return ratings;
        }

        public void Save(Ratings rating)
        {
            _dbContext.Add(rating);
            _dbContext.SaveChanges();
        }

        public void Update(Ratings rating)
        {
            _dbContext.Ratings.Update(rating);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Ratings rating = _dbContext.Ratings.Find(id);
            _dbContext.Remove(rating);
        }
    }
}
