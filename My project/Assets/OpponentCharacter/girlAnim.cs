using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlAnim : MonoBehaviour
{

    float distance;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z < 0)
        {
            animator.SetBool("run", true);
        }
        else
        {
            animator.SetBool("run", false);
        }
    }
}
