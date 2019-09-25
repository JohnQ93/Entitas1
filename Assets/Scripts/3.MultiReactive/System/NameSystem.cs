using Entitas;
using MultiReactive;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameSystem : ReactiveSystem<GameEntity> {

    public NameSystem(Contexts contexts) : base(contexts.game)
    {

    }
    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        throw new System.NotImplementedException();
    }

    protected override bool Filter(GameEntity entity)
    {
        throw new System.NotImplementedException();
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (GameEntity entity in entities)
        {
            entity.AddMultiReactiveName("qccccc");
        }

        Contexts.sharedInstance.game.GetEntitiesWithMultiReactiveName("qccccc");
    }
}
