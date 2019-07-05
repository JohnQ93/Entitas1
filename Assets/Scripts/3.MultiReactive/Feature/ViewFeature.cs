using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MultiReactive
{
    public class ViewFeature : Feature
    {
        public ViewFeature(Contexts contexts)
        {
            Add(new MultiViewSystem(contexts));
        }
    }
}