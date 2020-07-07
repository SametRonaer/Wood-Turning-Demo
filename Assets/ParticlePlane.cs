using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlane : MonoBehaviour
{
    [SerializeField]
    GameObject plane;
    [SerializeField]
    GameObject parentObject;

    List<ParticleCollisionEvent> collisionEvents;
    ParticleSystem particleLauncher;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        collisionEvents = new List<ParticleCollisionEvent>();
        particleLauncher = GetComponent<ParticleSystem>();
    }


    private void OnParticleCollision(GameObject other)
    {
       // Instantiate(plane, transform.position, Quaternion.identity);
       // plane.transform.parent = other.transform;
        ParticlePhysicsExtensions.GetCollisionEvents(particleLauncher, other, collisionEvents);

        for(int i = 0; i<collisionEvents.Count; i++)
        {
            //print(collisionEvents[i].intersection);
            
        }

        print("Particles!!");
    }

}
