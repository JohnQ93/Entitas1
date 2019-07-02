using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// 响应鼠标右键开始移动的系统
    /// </summary>
    public class StartMoveSystem : ReactiveSystem<InputEntity>
    {
        private GameContext _gameContext;
        private IGroup<GameEntity> _moveGroup;
        public StartMoveSystem(Contexts context) : base(context.input)
        {
            _gameContext = context.game;
            _moveGroup = context.game.GetGroup(GameMatcher.InteractionView);
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.InteractionMouse);
        }

        protected override bool Filter(InputEntity entity)
        {
            return entity.hasInteractionMouse
                && entity.interactionMouse.mouse == MouseButton.RIGHT
                && entity.interactionMouse.mouseEvent == MouseButtonEvent.DOWN;
        }

        protected override void Execute(List<InputEntity> entities)
        {
            foreach (InputEntity entity in entities)
            {
                var worldPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
                foreach (GameEntity gameEntity in _moveGroup)
                {
                    gameEntity.ReplaceInteractionMove(worldPos);
                }
            }
        }
    }
}
