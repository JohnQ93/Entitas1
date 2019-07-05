using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MultiReactive
{
    public class DestroyFeature : Feature {

        public DestroyFeature(Contexts contexts)
        {
            Add(new MultiDestroySystem(contexts));
        }
    }
}