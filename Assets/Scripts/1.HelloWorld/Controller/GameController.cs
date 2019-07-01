using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QC
{
    public class GameController : MonoBehaviour {

        private Systems _systems;
        // Use this for initialization
        void Start() {
            var contexts = Contexts.sharedInstance;
            _systems = new Feature("System").Add(new AddGameSystem(contexts));
            _systems.Initialize();
    }

        // Update is called once per frame
        void Update() {
            _systems.Execute();
            _systems.Cleanup();
        }
    }
}
