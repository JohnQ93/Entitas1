using Entitas;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// 旋转角度组件
    /// </summary>
    [Game]
    public class DirectionComponent : IComponent
    {
        /// <summary>
        /// 朝目标位置所要转动的角度
        /// </summary>
        public float direction;
    }
}
