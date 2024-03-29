//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public QC.LogComponent qCLog { get { return (QC.LogComponent)GetComponent(GameComponentsLookup.QCLog); } }
    public bool hasQCLog { get { return HasComponent(GameComponentsLookup.QCLog); } }

    public void AddQCLog(string newMessage) {
        var index = GameComponentsLookup.QCLog;
        var component = (QC.LogComponent)CreateComponent(index, typeof(QC.LogComponent));
        component.message = newMessage;
        AddComponent(index, component);
    }

    public void ReplaceQCLog(string newMessage) {
        var index = GameComponentsLookup.QCLog;
        var component = (QC.LogComponent)CreateComponent(index, typeof(QC.LogComponent));
        component.message = newMessage;
        ReplaceComponent(index, component);
    }

    public void RemoveQCLog() {
        RemoveComponent(GameComponentsLookup.QCLog);
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

    static Entitas.IMatcher<GameEntity> _matcherQCLog;

    public static Entitas.IMatcher<GameEntity> QCLog {
        get {
            if (_matcherQCLog == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.QCLog);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherQCLog = matcher;
            }

            return _matcherQCLog;
        }
    }
}
