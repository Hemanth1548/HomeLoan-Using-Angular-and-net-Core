namespace HOME_LOAN_BE.Repositories
{
    public interface IUserLogin<TEntity>
    {
        TEntity ValidateUser(TEntity entity);
    }
}