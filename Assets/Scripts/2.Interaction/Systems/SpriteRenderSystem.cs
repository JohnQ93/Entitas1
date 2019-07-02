using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace Interaction
{
    /// <summary>
    /// 添加Sprite组件系统
    /// </summary>
    public class SpriteRenderSystem : ReactiveSystem<GameEntity>
    {
        public SpriteRenderSystem(Contexts context) : base(context.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.InteractionSprite);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasInteractionSprite && entity.hasInteractionView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                Transform trans = entity.interactionView.viewTrans;
                SpriteRenderer sr = trans.GetComponent<SpriteRenderer>();
                if (sr == null) sr = trans.gameObject.AddComponent<SpriteRenderer>();
                sr.sprite = Resources.Load<Sprite>(entity.interactionSprite.spriteName);
            }
        }
    }
}