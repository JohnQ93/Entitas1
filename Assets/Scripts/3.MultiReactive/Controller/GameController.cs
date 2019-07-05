using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MultiReactive
{
    public class GameController : MonoBehaviour
    {
        private Contexts _context;
        private Systems _system;
        // Use this for initialization
        void Start()
        {
            _context = Contexts.sharedInstance;
            _system = new Feature("System").Add(new DestroyFeature(_context)).Add(new ViewFeature(_context));
        }

        // Update is called once per frame
        void Update()
        {
            _system.Execute();
            _system.Cleanup();
        }
    }
}