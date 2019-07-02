using Entitas;
using Entitas.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// 添加视图层系统
    /// </summary>
    public class AddViewSystem : ReactiveSystem<GameEntity>
    {
        private Transform _parent;
        public AddViewSystem(Contexts context) : base(context.game)
        {
            _parent = new GameObject("ViewParent").transform;
        }
        
        protected override bool Filter(GameEntity entity)
        {
            return !entity.hasInteractionView && entity.hasInteractionSprite;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.InteractionSprite);
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                GameObject go = new GameObject("View");
                go.transform.SetParent(_parent);
                go.Link(entity);
                entity.AddInteractionView(go.transform);
            }
        }
    }
}