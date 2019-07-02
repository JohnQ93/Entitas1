using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    public class GameFeature : Feature
    {
        public GameFeature(Contexts contexts)
        {
            Add(new AddViewSystem(contexts));
            Add(new SpriteRenderSystem(contexts));
            Add(new PositionSystem(contexts));
            Add(new DirectionSystem(contexts));
            Add(new MoveSystem(contexts));
            Add(new ChangeRotationSystem(contexts));
        }
    }
}