using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    Character character;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        character = GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Hori",character.x);
        animator.SetFloat("Vert", character.z);
    }
}
