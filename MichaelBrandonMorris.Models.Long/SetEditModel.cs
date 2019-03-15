using System.Collections.Generic;
using MichaelBrandonMorris.Entities.Long;

namespace MichaelBrandonMorris.Models.Long
{
    public abstract class SetEditModel<TEntity, TEditModel> : SetEditModel<TEntity, long, TEditModel>
        where TEntity : Entity, new()
        where TEditModel : EditModel<TEntity>
    {
        protected SetEditModel(ISet<TEntity> entities) : base(entities)
        {
        }
    }
}
