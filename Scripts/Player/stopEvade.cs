using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopEvade : MonoBehaviour
{
    void Start()
    {
        //Start the coroutine we define below named ExampleCoroutine.
        StartCoroutine(evadeCoroutine());
    }

    IEnumerator evadeCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
    }
}
