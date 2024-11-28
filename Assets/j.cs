using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class j: MonoBehaviour
{
    public int touchState = 0;

    private void OnTriggerEnter(Collider other)
    {
        touchState = 1;
    }
    private void OnTriggerExit(Collider other)
    {
        touchState = 0;
    }
}
