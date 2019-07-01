using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    public class MouseSystem : IInitializeSystem, IExecuteSystem
    {
        private InputEntity _inputEntity;
        private InputContext _inputContext;

        public MouseSystem(Contexts context)
        {
            _inputContext = context.input;
        }

        public void Initialize()
        {
            _inputEntity = _inputContext.interactionMouseEntity;
        }

        public void Execute()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _inputEntity.ReplaceInteractionMouse(MouseButton.LEFT, MouseButtonEvent.DOWN);
            }
            if (Input.GetMouseButtonDown(1))
            {
                _inputEntity.ReplaceInteractionMouse(MouseButton.RIGHT, MouseButtonEvent.DOWN);
            }
        }
    }
}
