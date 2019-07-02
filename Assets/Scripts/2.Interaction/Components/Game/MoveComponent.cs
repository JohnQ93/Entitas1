using Entitas;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// 移动目标位置组件
    /// </summary>
    [Game]
    public class MoveComponent : IComponent
    {
        /// <summary>
        /// 点击屏幕所要移动的目标位置
        /// </summary>
        public Vector3 target;
    }
}
