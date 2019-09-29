using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        public void CreateBall()
        {

        }

        public void CreateBlocker()
        {

        }
    }
}