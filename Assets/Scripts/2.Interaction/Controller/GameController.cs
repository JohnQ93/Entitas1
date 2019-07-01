using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    public class GameController : MonoBehaviour
    {
        private Systems _systems;
        private Contexts _contexts;
        // Use this for initialization
        void Start()
        {
            _contexts = Contexts.sharedInstance;
            _systems = new Feature("System").Add(new GameFeature(_contexts));
        }

        // Update is called once per frame
        void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }
    }
}