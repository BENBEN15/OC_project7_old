using System.Collections.Generic;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class CurvePointsRepository : IRepository<CurvePoints>
    {
        private readonly PoseidonDBContext _dbContext;

        public CurvePointsRepository(PoseidonDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CurvePoints Get(int id)
        {
            CurvePoints curvePoint = _dbContext.CurvePoints.Find(id);
            return curvePoint;
        }

        public IEnumerable<CurvePoints> GetAll()
        {
            IEnumerable<CurvePoints> curvePoints = _dbContext.CurvePoints;
            return curvePoints;
        }

        public void Save(CurvePoints curvePoints)
        {
            _dbContext.Add(curvePoints);
            _dbContext.SaveChanges();
        }

        public void Update(CurvePoints curvePoints)
        {
            _dbContext.CurvePoints.Update(curvePoints);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            CurvePoints curvePoints = _dbContext.CurvePoints.Find(id);
            _dbContext.Remove(curvePoints);
        }
    }
}
