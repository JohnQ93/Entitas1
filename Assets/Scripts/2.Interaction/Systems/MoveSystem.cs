using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using DG.Tweening;

namespace Interaction
{
    public class MoveSystem : ReactiveSystem<GameEntity>
    {
        public MoveSystem(Contexts context) : base(context.game)
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
                //entity.isInteractionMoveComplete = false;
                entity.interactionView.viewTrans.DOMove(entity.interactionMove.target, 2).OnComplete(() => {
                    entity.isInteractionMoveComplete = true;
                });
            }
        }
    }
}
