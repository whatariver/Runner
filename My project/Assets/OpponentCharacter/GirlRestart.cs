using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GirlRestart : MonoBehaviour
{
    Vector3 startPos;

    void Start()
    {
        startPos = this.transform.position;
    }



    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obs")
        {
            transform.position = startPos;
        }
    }
}