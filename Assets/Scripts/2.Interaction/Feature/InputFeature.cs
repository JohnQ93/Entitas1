using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    public class InputFeature : Feature
    {
        public InputFeature(Contexts contexts)
        {
            Add(new MouseSystem(contexts));
            Add(new CreaterSystem(contexts));
            Add(new StartMoveSystem(contexts));
        }
    }
}