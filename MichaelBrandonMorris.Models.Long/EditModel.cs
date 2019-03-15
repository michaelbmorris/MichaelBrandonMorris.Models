using MichaelBrandonMorris.Entities.Long;

namespace MichaelBrandonMorris.Models.Long
{
    public abstract class EditModel<TEntity> : EditModel<TEntity, long> where TEntity : Entity, new()
    {
        protected EditModel(TEntity entity) : base(entity)
        {
        }
    }
}
