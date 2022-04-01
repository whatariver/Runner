using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girlAnim : MonoBehaviour
{

    float distance;
    Animator animator;
    Character character;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        character = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(character.transform.position, this.transform.position);
        if (distance < 4)
        {
            animator.SetFloat("happy", 1);
        }
        else animator.SetFloat("happy", 0);

    }
}
