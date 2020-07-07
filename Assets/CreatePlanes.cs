using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlanes : MonoBehaviour
{
    [SerializeField]
    GameObject plane;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.rigidbody != null)
                {
                 //   Instantiate(plane, hit.point, Quaternion.identity);
                    
                }
            }
        }
    }
}
