using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace Interaction
{
    public class DirectionSystem : ReactiveSystem<GameEntity>
    {
        public DirectionSystem(Contexts context) : base(context.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.InteractionMove);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasInteractionMove 
                   && entity.isInteractionMoveComplete 
                   && entity.hasInteractionView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                Transform view = entity.interactionView.viewTrans;
                Vector3 target = entity.interactionMove.target;
                Vector3 direction = (target - view.position).normalized;
                //四元数版本
                //Quaternion angleOffset = Quaternion.FromToRotation(view.up, direction);
                //view.rotation *= angleOffset;
                //普通版本
                float angle = Mathf.Atan2(direction.x, direction.y);
                entity.ReplaceInteractionDirection(angle);
            }
        }
    }
}