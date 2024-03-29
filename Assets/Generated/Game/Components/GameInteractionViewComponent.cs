//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Interaction.ViewComponent interactionView { get { return (Interaction.ViewComponent)GetComponent(GameComponentsLookup.InteractionView); } }
    public bool hasInteractionView { get { return HasComponent(GameComponentsLookup.InteractionView); } }

    public void AddInteractionView(UnityEngine.Transform newViewTrans) {
        var index = GameComponentsLookup.InteractionView;
        var component = (Interaction.ViewComponent)CreateComponent(index, typeof(Interaction.ViewComponent));
        component.viewTrans = newViewTrans;
        AddComponent(index, component);
    }

    public void ReplaceInteractionView(UnityEngine.Transform newViewTrans) {
        var index = GameComponentsLookup.InteractionView;
        var component = (Interaction.ViewComponent)CreateComponent(index, typeof(Interaction.ViewComponent));
        component.viewTrans = newViewTrans;
        ReplaceComponent(index, component);
    }

    public void RemoveInteractionView() {
        RemoveComponent(GameComponentsLookup.InteractionView);
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

    static Entitas.IMatcher<GameEntity> _matcherInteractionView;

    public static Entitas.IMatcher<GameEntity> InteractionView {
        get {
            if (_matcherInteractionView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InteractionView);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInteractionView = matcher;
            }

            return _matcherInteractionView;
        }
    }
}
