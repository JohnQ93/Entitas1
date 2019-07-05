using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace MultiReactive
{
    public class MultiDestroySystem : MultiReactiveSystem<IMultiDestroyEntity, Contexts>
    {
        public MultiDestroySystem(Contexts contexts) : base(contexts)
        {
        }

        protected override ICollector[] GetTrigger(Contexts contexts)
        {
            return new ICollector[]
            {
                contexts.game.CreateCollector(GameMatcher.MultiReactiveDestroy),
                contexts.input.CreateCollector(InputMatcher.MultiReactiveDestroy),
                contexts.uI.CreateCollector(UIMatcher.MultiReactiveDestroy)
            };
        }

        protected override bool Filter(IMultiDestroyEntity entity)
        {
            return entity.isMultiReactiveDestroy;
        }

        protected override void Execute(List<IMultiDestroyEntity> entities)
        {
            foreach (IMultiDestroyEntity entity in entities)
            {
                if (entity.hasMultiReactiveView)
                {
                    GameObject.Destroy(entity.multiReactiveView.viewTrans.gameObject);
                }
                Debug.Log("在" + entity.contextInfo.name + "上下文中销毁了");
            }
        }
    }
}

public interface IMultiDestroyEntity : IEntity, IMultiReactiveDestroyEntity, IMultiReactiveViewEntity { }

public partial class GameEntity : IMultiDestroyEntity { }
public partial class InputEntity : IMultiDestroyEntity { }
public partial class UIEntity : IMultiDestroyEntity { }