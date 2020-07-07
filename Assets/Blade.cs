using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{

    GameObject particles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(particles.name);   
    }


    private void OnCollisionEnter(Collision collision)
    {
       particles = collision.gameObject.transform.parent.gameObject.transform.GetChild(1).gameObject;
        print(particles.name);
    }

}
