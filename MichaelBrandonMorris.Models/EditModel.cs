using AutoMapper;
using MichaelBrandonMorris.Entities;

namespace MichaelBrandonMorris.Models
{
    public abstract class EditModel<TEntity, TId> : DisplayModel<TEntity, TId>, IEditModel<TEntity> where TEntity : Entity<TId>, new()
    {
        protected EditModel(TEntity entity) : base(entity)
        {
        }

        public TEntity ToEntity()
        {
            return Mapper.Map(this, new TEntity());
        }
    }

    public interface IEditModel<out TEntity>
    {
        TEntity ToEntity();
    }
}
