using Entitas;
using UnityEngine;
using Entitas.CodeGeneration.Attributes;

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

    [Game, Event(EventTarget.Any)]
    public class NameComponent : IComponent
    {
        [EntityIndex]
        public string name;
    }
}