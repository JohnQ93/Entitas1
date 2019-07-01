using Entitas;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// Sprite组件
    /// </summary>
    [Game]
    public class SpriteComponent : IComponent
    {
        /// <summary>
        /// 图片路径
        /// </summary>
        public string spriteName;
    }
}