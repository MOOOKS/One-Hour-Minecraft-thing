using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 5))
            {
                if (hit.collider.tag == "cube")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }            
    }
}
