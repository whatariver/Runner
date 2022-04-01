using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlatform : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == Player)
        {
            Player.transform.parent = transform ;
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }
}
