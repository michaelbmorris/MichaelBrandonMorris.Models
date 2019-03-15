using System.Collections.Generic;
using MichaelBrandonMorris.Entities.Long;

namespace MichaelBrandonMorris.Models.Long
{
    public abstract class SetDisplayModel<TEntity, TDisplayModel> : SetDisplayModel<TEntity, long, TDisplayModel> where TEntity : Entity where TDisplayModel : DisplayModel<TEntity>
    {
        protected SetDisplayModel(ISet<TEntity> entities) : base(entities)
        {
        }
    }
}
