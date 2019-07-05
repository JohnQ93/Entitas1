using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MultiReactive
{
    public class InputController : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                GameObject go = new GameObject();
                Contexts.sharedInstance.game.CreateEntity().AddMultiReactiveView(go.transform);//.isMultiReactiveDestroy = true;
            }

            if (Input.GetMouseButtonDown(1))
            {
                Contexts.sharedInstance.input.CreateEntity().isMultiReactiveDestroy = true;
            }

            if (Input.GetMouseButtonDown(2))
            {
                Contexts.sharedInstance.uI.CreateEntity().isMultiReactiveDestroy = true;
            }
        }
    }
}