//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public static class GameComponentsLookup {

    public const int InteractionDirection = 0;
    public const int InteractionPosition = 1;
    public const int InteractionSprite = 2;
    public const int InteractionView = 3;
    public const int QCLog = 4;

    public const int TotalComponents = 5;

    public static readonly string[] componentNames = {
        "InteractionDirection",
        "InteractionPosition",
        "InteractionSprite",
        "InteractionView",
        "QCLog"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(Interaction.DirectionComponent),
        typeof(Interaction.PositionComponent),
        typeof(Interaction.SpriteComponent),
        typeof(Interaction.ViewComponent),
        typeof(QC.LogComponent)
    };
}