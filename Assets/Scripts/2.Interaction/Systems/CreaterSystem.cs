using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// 创建实体系统
    /// </summary>
    public class CreaterSystem : ReactiveSystem<InputEntity>
    {
        private GameContext _gameContext;
        public CreaterSystem(Contexts context) : base(context.input)
        {
            _gameContext = context.game;
        }

        protected override void Execute(List<InputEntity> entities)
        {
            foreach (InputEntity entity in entities)
            {
                var gameEntity = _gameContext.CreateEntity();
                gameEntity.AddInteractionSprite("pool");
                var worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                gameEntity.AddInteractionPosition(worldPos);
            }
        }

        protected override bool Filter(InputEntity entity)
        {
            return entity.hasInteractionMouse
                && entity.interactionMouse.mouse == MouseButton.LEFT
                && entity.interactionMouse.mouseEvent == MouseButtonEvent.DOWN;
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.InteractionMouse);
        }
    }
}
