using MichaelBrandonMorris.Entities.Long;

namespace MichaelBrandonMorris.Models.Long
{
    public abstract class DisplayModel<TEntity> : DisplayModel<TEntity, long> where TEntity : Entity
    {
        protected DisplayModel(TEntity entity) : base(entity)
        {
        }
    }
}
