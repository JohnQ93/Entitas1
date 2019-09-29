using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace Game
{
    /// <summary>
    /// 游戏面板
    /// </summary>
    [Game]
    public class GameBoardComponent : IComponent
    {
        /// <summary>
        /// 列
        /// </summary>
        public int columns;
        /// <summary>
        /// 行
        /// </summary>
        public int rows;
    }
    /// <summary>
    /// 游戏界面元素
    /// </summary>
    [Game]
    public class GameBoardItemComponent : IComponent
    {

    }

    /// <summary>
    /// 游戏元素消除组件
    /// </summary>
    [Game]
    public class DestroyComponent : IComponent
    {

    }
}