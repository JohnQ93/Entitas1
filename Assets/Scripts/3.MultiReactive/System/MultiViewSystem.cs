using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.Unity;

namespace MultiReactive
{
    public class MultiViewSystem : MultiReactiveSystem<IMultiViewEntity, Contexts>
    {
        private Dictionary<string, Transform> _parentDic;
        private Contexts _contexts;
        public MultiViewSystem(Contexts contexts) : base(contexts)
        {
            _contexts = contexts;
            _parentDic = new Dictionary<string, Transform>();
            foreach (var context in contexts.allContexts)
            {
                string name = context.contextInfo.name;
                _parentDic[name] = new GameObject(name + "ViewParent").transform;
            }
        }

        protected override ICollector[] GetTrigger(Contexts contexts)
        {
            return new ICollector[]
            {
                contexts.game.CreateCollector(GameMatcher.MultiReactiveView),
                contexts.input.CreateCollector(InputMatcher.MultiReactiveView),
                contexts.uI.CreateCollector(UIMatcher.MultiReactiveView)
            };
        }

        protected override bool Filter(IMultiViewEntity entity)
        {
            return true;// entity.hasMultiReactiveView;
        }

        protected override void Execute(List<IMultiViewEntity> entities)
        {
            foreach (IMultiViewEntity entity in entities)
            {
                string name = entity.contextInfo.name;
                GameObject go = new GameObject(name + "View");
                go.transform.SetParent(_parentDic[name]);
                entity.AddMultiReactiveView(go.transform);
                Debug.Log(_contexts.getContextByName(name));
                go.Link(entity);
            }
        }
    }

    public static class ContextsExtension
    {
        private static Dictionary<string, IContext> _contextDic = new Dictionary<string, IContext>();
        public static IContext getContextByName(this Contexts context, string name)
        {
            initDic(context);
            return _contextDic[name];
        }

        public static void initDic(Contexts contexts)
        {
            foreach (var context in contexts.allContexts)
            {
                string name = context.contextInfo.name;
                _contextDic[name] = context;
            }
        }
    }
}
public interface IMultiViewEntity : IEntity, IMultiReactiveViewEntity { }

public partial class GameEntity : IMultiViewEntity { }
public partial class InputEntity : IMultiViewEntity { }
public partial class UIEntity : IMultiViewEntity { }


