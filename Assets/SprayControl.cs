using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayControl : MonoBehaviour
{
    Vector3 sprayPosition;
    Vector3 mousePosition;
    Vector3 differencePosition;
    // Start is called before the first frame update
    void Start()
    {
         mousePosition = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        PositionControl();
        
    }



    void PositionControl()
    {
        sprayPosition = transform.position;

        
            
            if(mousePosition.x > Input.mousePosition.x)
        {
            differencePosition = mousePosition - Input.mousePosition;
            transform.position = sprayPosition + differencePosition;
            mousePosition = Input.mousePosition;

        } else if (mousePosition.x < Input.mousePosition.x)
        {
            differencePosition = mousePosition - Input.mousePosition;
            transform.position = sprayPosition + differencePosition;
            mousePosition = Input.mousePosition;
        }

            

        
    }


}
