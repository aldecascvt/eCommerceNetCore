namespace Commerce.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        void Save();

        #region Repositories
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        IProductRepository Product { get; }

        #endregion
    }
}
