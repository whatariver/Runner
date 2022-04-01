using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveA : MonoBehaviour
{

    public GameObject Player;
    public Character rotation;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        rotation = Player.GetComponent<Character>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == Player)
        {
            Player.GetComponent<Character>().r = 1;
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject == Player)
        {
            Player.GetComponent<Character>().r = 0;
        }
    }
}
