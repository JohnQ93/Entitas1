using Entitas;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// 创建实体位置组件
    /// </summary>
    [Game]
    public class PositionComponent : IComponent
    {
        /// <summary>
        /// 点击屏幕创建实体的位置坐标
        /// </summary>
        public Vector3 position;
    }
}