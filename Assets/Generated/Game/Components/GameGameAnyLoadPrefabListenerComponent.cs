//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GameAnyLoadPrefabListenerComponent gameAnyLoadPrefabListener { get { return (GameAnyLoadPrefabListenerComponent)GetComponent(GameComponentsLookup.GameAnyLoadPrefabListener); } }
    public bool hasGameAnyLoadPrefabListener { get { return HasComponent(GameComponentsLookup.GameAnyLoadPrefabListener); } }

    public void AddGameAnyLoadPrefabListener(System.Collections.Generic.List<IGameAnyLoadPrefabListener> newValue) {
        var index = GameComponentsLookup.GameAnyLoadPrefabListener;
        var component = (GameAnyLoadPrefabListenerComponent)CreateComponent(index, typeof(GameAnyLoadPrefabListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameAnyLoadPrefabListener(System.Collections.Generic.List<IGameAnyLoadPrefabListener> newValue) {
        var index = GameComponentsLookup.GameAnyLoadPrefabListener;
        var component = (GameAnyLoadPrefabListenerComponent)CreateComponent(index, typeof(GameAnyLoadPrefabListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameAnyLoadPrefabListener() {
        RemoveComponent(GameComponentsLookup.GameAnyLoadPrefabListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGameAnyLoadPrefabListener;

    public static Entitas.IMatcher<GameEntity> GameAnyLoadPrefabListener {
        get {
            if (_matcherGameAnyLoadPrefabListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameAnyLoadPrefabListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameAnyLoadPrefabListener = matcher;
            }

            return _matcherGameAnyLoadPrefabListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddGameAnyLoadPrefabListener(IGameAnyLoadPrefabListener value) {
        var listeners = hasGameAnyLoadPrefabListener
            ? gameAnyLoadPrefabListener.value
            : new System.Collections.Generic.List<IGameAnyLoadPrefabListener>();
        listeners.Add(value);
        ReplaceGameAnyLoadPrefabListener(listeners);
    }

    public void RemoveGameAnyLoadPrefabListener(IGameAnyLoadPrefabListener value, bool removeComponentWhenEmpty = true) {
        var listeners = gameAnyLoadPrefabListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveGameAnyLoadPrefabListener();
        } else {
            ReplaceGameAnyLoadPrefabListener(listeners);
        }
    }
}
