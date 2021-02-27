using Core.DataAccess;
using Entities.Concrete;

namespace Business.Consrete
{
    public interface ICarImageDal : IEntityRepository<CarImage>
    {
        bool IsExist(int id);
    }
}