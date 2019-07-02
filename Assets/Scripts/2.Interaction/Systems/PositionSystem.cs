using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace Interaction
{
    /// <summary>
    /// 生成位置系统
    /// </summary>
    public class PositionSystem : ReactiveSystem<GameEntity>
    {
        public PositionSystem(Contexts context) : base(context.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.InteractionPosition);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasInteractionPosition && entity.hasInteractionView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                entity.interactionView.viewTrans.position = entity.interactionPosition.position;
            }
        }
    }
}
