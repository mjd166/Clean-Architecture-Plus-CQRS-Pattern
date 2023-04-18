using System.Threading.Tasks;
namespace Final_SophieTravelManagement.Shared.Abstractions.Queries
{
    public interface IQueryHandler<in TQuery,TResult> where TQuery:class, IQuery<TResult>
    {
        Task<TResult> HandleAsync(TQuery query);
    }
}
