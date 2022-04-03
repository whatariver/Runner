using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public Transform target;
    CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        if(characterController.enabled == false)
        {
            transform.LookAt(target);
            Camera.main.orthographic = true; // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }
    }
}
