using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Interaction
{
    public class ChangeRotationSystem : ReactiveSystem<GameEntity>
    {
        public ChangeRotationSystem(Contexts context) : base(context.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.InteractionDirection);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasInteractionDirection 
                   && entity.hasInteractionView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                Transform view = entity.interactionView.viewTrans;
                var angle = entity.interactionDirection.direction;
                view.rotation = Quaternion.AngleAxis(-angle * 180 / Mathf.PI, view.forward);
            }
        }
    }
}