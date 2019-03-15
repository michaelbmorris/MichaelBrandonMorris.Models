using AutoMapper;
using MichaelBrandonMorris.Entities;

namespace MichaelBrandonMorris.Models
{
    public abstract class DisplayModel<TEntity, TId> where TEntity : Entity<TId>
    {
        protected DisplayModel(TEntity entity)
        {
            PopulateModel(entity);
        }

        public TId Id { get; set; }

        protected void PopulateModel(TEntity entity)
        {
            Mapper.Map(entity, this);
        }
    }
}
