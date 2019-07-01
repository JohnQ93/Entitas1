using Entitas;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// 坐标组件
    /// </summary>
    [Game]
    public class PositionComponent : IComponent
    {
        /// <summary>
        /// 点击位置坐标
        /// </summary>
        public Vector2 position;
    }
}