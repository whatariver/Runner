using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintable : MonoBehaviour
{
    public GameObject Brush;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit))
            {
                var go = Instantiate(Brush, hit.point + Vector3.forward * -0.1f, Quaternion.identity, transform);
                if (Vector3.Distance(transform.position,go.transform.position) > 5)
                {
                    Destroy(go);
                }
            }
        }
    }
}
