namespace WebShopBrodova.DataAccess.Repository.IRepository;

public interface IUnitOfWork
{
    ITypeOfBoatRepository TypeOfBoat { get; set; }
    void Save();
}