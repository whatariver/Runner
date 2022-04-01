using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obs")
        {
            SceneManager.LoadScene(0);
        }
    }
}