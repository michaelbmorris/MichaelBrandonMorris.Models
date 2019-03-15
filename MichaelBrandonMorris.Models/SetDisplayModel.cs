using System;
using System.Collections.Generic;
using MichaelBrandonMorris.Entities;

namespace MichaelBrandonMorris.Models
{
    public abstract class SetDisplayModel<TEntity, TId, TDisplayModel> : HashSet<TDisplayModel> where TEntity : Entity<TId> where TDisplayModel : DisplayModel<TEntity, TId>
    {
        protected SetDisplayModel(ISet<TEntity> entities)
        {
            PopulateModel(entities);
        }

        private void PopulateModel(ISet<TEntity> entities)
        {
            if (entities == null)
            {
                return;
            }

            foreach (var entity in entities)
            {
                Add(Activator.CreateInstance(typeof(TDisplayModel), entity) as TDisplayModel);
            }
        }
    }
}
