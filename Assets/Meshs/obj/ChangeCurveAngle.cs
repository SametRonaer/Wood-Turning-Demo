using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCurveAngle : MonoBehaviour
{
    GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        gameObject = (GameObject)Resources.Load("CurvePaper_000001.obj");
        Instantiate(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
