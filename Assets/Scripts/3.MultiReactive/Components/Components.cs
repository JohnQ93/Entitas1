using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MultiReactive
{
    /// <summary>
    /// 多上下文销毁组件
    /// </summary>
    [Game,Input,UI]
    public class DestroyComponent : IComponent
    {

    }
    /// <summary>
    /// 多上下文View组件
    /// </summary>
    [Game, Input, UI]
    public class ViewComponent : IComponent
    {
        public Transform viewTrans;
    }
}