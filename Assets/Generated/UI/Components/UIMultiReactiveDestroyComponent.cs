//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UIEntity {

    static readonly MultiReactive.DestroyComponent multiReactiveDestroyComponent = new MultiReactive.DestroyComponent();

    public bool isMultiReactiveDestroy {
        get { return HasComponent(UIComponentsLookup.MultiReactiveDestroy); }
        set {
            if (value != isMultiReactiveDestroy) {
                var index = UIComponentsLookup.MultiReactiveDestroy;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : multiReactiveDestroyComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UIEntity : IMultiReactiveDestroyEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class UIMatcher {

    static Entitas.IMatcher<UIEntity> _matcherMultiReactiveDestroy;

    public static Entitas.IMatcher<UIEntity> MultiReactiveDestroy {
        get {
            if (_matcherMultiReactiveDestroy == null) {
                var matcher = (Entitas.Matcher<UIEntity>)Entitas.Matcher<UIEntity>.AllOf(UIComponentsLookup.MultiReactiveDestroy);
                matcher.componentNames = UIComponentsLookup.componentNames;
                _matcherMultiReactiveDestroy = matcher;
            }

            return _matcherMultiReactiveDestroy;
        }
    }
}
