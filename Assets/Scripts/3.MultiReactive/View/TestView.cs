using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestView : MonoBehaviour, IMultiReactiveAnyNameListener {
    public void OnMultiReactiveAnyName(GameEntity entity, string name)
    {
        Debug.Log("包含Event标签的组件数据被改变了之后，Any会把所有继承该接口的方法都调用一遍，Self只会把含有该组件的实体调用一遍");
    }
}
