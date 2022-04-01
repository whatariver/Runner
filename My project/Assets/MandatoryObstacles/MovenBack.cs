using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovenBack : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float speed;
    public float distance ;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;
        distance = Vector3.Distance(transform.position, end.position);
        transform.position = Vector3.MoveTowards(transform.position, end.position, step);

        if(distance < 0.1)
        {
            (start, end) = (end, start);

        }

    }
}
