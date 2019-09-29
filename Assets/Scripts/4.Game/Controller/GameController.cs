using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class GameController : MonoBehaviour
    {
        private Systems _systems;

        private void Awake()
        {
            var contexts = Contexts.sharedInstance;
            _systems = new GameFeature(contexts).Add(new GameEventSystems(contexts));
            new Services(contexts, transform);
        }

        private void Start()
        {
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }
    }
}