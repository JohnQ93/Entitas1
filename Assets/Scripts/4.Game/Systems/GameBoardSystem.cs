using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace Game
{
    /// <summary>
    /// 游戏面板响应系统
    /// </summary>
    public class GameBoardSystem : ReactiveSystem<GameEntity>, IInitializeSystem
    {
        private IGroup<GameEntity> _itemsGroup;
        public GameBoardSystem(Contexts contexts) : base(contexts.game)
        {
            _itemsGroup = contexts.game.GetGroup(GameMatcher.GameGameBoardItem);
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.GameGameBoard);
        }


        protected override bool Filter(GameEntity entity)
        {
            return entity.hasGameGameBoard;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            var gameBoard = entities.SingleEntity().gameGameBoard;
            foreach (GameEntity entity in _itemsGroup)
            {
                //todo:超出游戏面板范围的元素需要消除
            }
        }

        public void Initialize()
        {
            GameBoardComponent gameBoard = CreaterService.Instance.CreateGameBoard().gameGameBoard;

            for (int x = 0; x < gameBoard.columns; x++)
            {
                for (int y = 0; y < gameBoard.rows; y++)
                {
                    if (RandomBlocker())
                    {
                        //生成障碍块
                        CreaterService.Instance.CreateBlocker();
                    }
                    else
                    {
                        //生成消消球
                        CreaterService.Instance.CreateBall();
                    }
                }
            }
        }

        //根据随机生成的概率判断是否生成障碍
        private bool RandomBlocker()
        {
            int num = Random.Range(0, 10);

            if(num < 1)  //10%的概率生成障碍
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}