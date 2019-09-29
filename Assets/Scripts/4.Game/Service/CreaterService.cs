using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Data;

namespace Game
{
    /// <summary>
    /// 创建新元素服务
    /// </summary>
    public class CreaterService
    {

        private static CreaterService _instance;

        public static CreaterService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CreaterService();
                }
                return _instance;
            }
        }

        private Contexts _contexts;
        public void Init(Contexts contexts)
        {
            _contexts = contexts;
        }

        public GameEntity CreateGameBoard()
        {
            var entity = _contexts.game.CreateEntity();
            entity.AddGameGameBoard(8,9);
            return entity;
        }

        /// <summary>
        /// 生成可移动元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public GameEntity CreateBall(CustomVector2 index)
        {
            var entity = _contexts.game.CreateEntity();
            entity.isGameGameBoardItem = true;
            entity.isGameMovable = true;
            entity.AddGameItemIndex(index);
            entity.AddGameLoadPrefab(RandomPathService.RandomPath());
            return entity;
        }

        /// <summary>
        /// 生成障碍
        /// </summary>
        /// <param name="index"></param>
        public GameEntity CreateBlocker(CustomVector2 index)
        {
            var entity = _contexts.game.CreateEntity();
            entity.isGameGameBoardItem = true;
            entity.isGameMovable = false;
            entity.AddGameItemIndex(index);
            entity.AddGameLoadPrefab(ResPath.BlockerPath);
            return entity;
        }
    }
}