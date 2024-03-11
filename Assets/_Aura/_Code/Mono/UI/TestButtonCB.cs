using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButtonCB : MonoBehaviour
{
    public void RunTest()
    {
        Debug.Log($"Hello from {this.GetType().Name}");
    }
}
