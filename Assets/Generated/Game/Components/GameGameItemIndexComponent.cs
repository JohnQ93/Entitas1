//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Game.ItemIndexComponent gameItemIndex { get { return (Game.ItemIndexComponent)GetComponent(GameComponentsLookup.GameItemIndex); } }
    public bool hasGameItemIndex { get { return HasComponent(GameComponentsLookup.GameItemIndex); } }

    public void AddGameItemIndex(Game.Data.CustomVector2 newIndex) {
        var index = GameComponentsLookup.GameItemIndex;
        var component = (Game.ItemIndexComponent)CreateComponent(index, typeof(Game.ItemIndexComponent));
        component.index = newIndex;
        AddComponent(index, component);
    }

    public void ReplaceGameItemIndex(Game.Data.CustomVector2 newIndex) {
        var index = GameComponentsLookup.GameItemIndex;
        var component = (Game.ItemIndexComponent)CreateComponent(index, typeof(Game.ItemIndexComponent));
        component.index = newIndex;
        ReplaceComponent(index, component);
    }

    public void RemoveGameItemIndex() {
        RemoveComponent(GameComponentsLookup.GameItemIndex);
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

    static Entitas.IMatcher<GameEntity> _matcherGameItemIndex;

    public static Entitas.IMatcher<GameEntity> GameItemIndex {
        get {
            if (_matcherGameItemIndex == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameItemIndex);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameItemIndex = matcher;
            }

            return _matcherGameItemIndex;
        }
    }
}
