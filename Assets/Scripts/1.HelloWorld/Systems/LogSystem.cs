using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QC
{
    public class LogSystem : ReactiveSystem<GameEntity>
    {

        public LogSystem(Contexts contexts) : base(contexts.game)
        {

        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasQCLog;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.QCLog);
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                Debug.Log(entity.qCLog.message);
            }
        }
    }
}
