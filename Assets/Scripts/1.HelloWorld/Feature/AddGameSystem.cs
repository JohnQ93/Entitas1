namespace QC
{
    /// <summary>
    /// 添加游戏系统到框架内
    /// </summary>
    public class AddGameSystem : Feature
    {
        public AddGameSystem(Contexts contexts) : base("AddGameSystem")
        {
            Add(new InitSystem(contexts));
            Add(new LogSystem(contexts));
        }
    }
}
