using System.Collections;
using System.Collections.Generic;
using Entitas;
using Game.Data;
using UnityEngine;
using DG.Tweening;

namespace Game
{
    /// <summary>
    /// 游戏元素视图
    /// </summary>
    public class GameItemView : View, IGameItemIndexListener
    {
        public override void Link(IEntity entity, IContext context)
        {
            base.Link(entity, context);
            _gameEntity.AddGameItemIndexListener(this);
        }

        public override void OnGameDestroy(GameEntity entity)
        {
            base.OnGameDestroy(entity);
            float time = 0.5f;
            transform.DOScale(Vector3.one * 1.5f, time);
            transform.GetComponent<SpriteRenderer>().DOColor(Color.clear, time);
        }

        public void OnGameItemIndex(GameEntity entity, CustomVector2 index)
        {
            transform.DOMove(new Vector3(index.x, index.y, 0), 0.3f);
        }
    }
}