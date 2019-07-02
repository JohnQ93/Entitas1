using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interaction
{
    /// <summary>
    /// 鼠标响应事件系统
    /// </summary>
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
                _inputContext.ReplaceInteractionMouse(MouseButton.LEFT, MouseButtonEvent.DOWN);
            }
            if (Input.GetMouseButtonDown(1))
            {
                _inputContext.ReplaceInteractionMouse(MouseButton.RIGHT, MouseButtonEvent.DOWN);
            }
        }
    }
}
