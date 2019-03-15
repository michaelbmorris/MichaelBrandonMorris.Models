using System.Collections.Generic;
using System.Linq;
using MichaelBrandonMorris.Entities;

namespace MichaelBrandonMorris.Models
{
    public abstract class SetEditModel<TEntity, TId, TEditModel> : SetDisplayModel<TEntity, TId, TEditModel>, ISetEditModel<TEntity> where TEntity : Entity<TId>, new() where TEditModel : EditModel<TEntity, TId>
    {
        protected SetEditModel(ISet<TEntity> entities) : base(entities)
        {
        }

        public ISet<TEntity> ToEntities()
        {
            return new HashSet<TEntity>(this.Select(x => x.ToEntity()));
        }
    }

    public interface ISetEditModel<TEntity>
    {
        ISet<TEntity> ToEntities();
    }
}
