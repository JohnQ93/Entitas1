using Entitas;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// 方向组件
    /// </summary>
    [Game]
    public class DirectionComponent : IComponent
    {
        /// <summary>
        /// 方向
        /// </summary>
        public float direction;
    }
}
