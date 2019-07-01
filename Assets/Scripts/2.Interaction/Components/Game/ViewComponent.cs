using Entitas;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// 视图层组件
    /// </summary>
    [Game]
    public class ViewComponent : IComponent
    {
        /// <summary>
        /// 视图层对象
        /// </summary>
        public Transform viewTrans;
    }
}