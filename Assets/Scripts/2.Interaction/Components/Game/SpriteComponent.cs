using Entitas;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// Sprite路径组件
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