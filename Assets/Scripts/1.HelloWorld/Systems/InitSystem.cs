using Entitas;

namespace QC
{
    /// <summary>
    /// 初始化系统
    /// </summary>
    public class InitSystem : IInitializeSystem
    {
        public readonly GameContext _gameContext;

        public InitSystem(Contexts contexts)
        {
            _gameContext = contexts.game;
        }

        public void Initialize()
        {
            _gameContext.CreateEntity().AddQCLog("Hello World");
        }
    }
}
