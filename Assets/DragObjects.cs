using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
    private Vector3 mOffset;
    private float mzCoordinates;

    private void OnMouseDown()
    {
        mOffset = gameObject.transform.position - GetMouseWorlPos();
        mzCoordinates = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
    }

    private Vector3 GetMouseWorlPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mzCoordinates;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag()
    {
        //pixel coordinates
        // transform.position = GetMouseWorlPos() + mOffset;
        transform.position = new Vector3(GetMouseWorlPos().x + mOffset.x, transform.position.y, GetMouseWorlPos().z + mOffset.z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
