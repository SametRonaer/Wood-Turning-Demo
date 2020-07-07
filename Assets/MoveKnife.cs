using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKnife : MonoBehaviour
{
    bool selected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveKnife();
    }


    private void OnMouseDown()
    {
        print("Click!");
        selected = true;
    }


    void moveKnife()
    {
        if (Input.GetKey(KeyCode.UpArrow) && selected)
        {
            transform.localPosition = new Vector3(0,0.1f,0)+transform.localPosition;
        }
    }

}
