using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSense : MonoBehaviour
{

    Vector3 Scale;

    [SerializeField]
    Material cutFirstStage;
    [SerializeField]
    Material cutSecondStage;
    [SerializeField]
    Material cutThirdStage;

    string nameOfSlice;

    Dictionary<string, int> cuttedSlices = new Dictionary<string, int>();
    GameObject particles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


     void OnCollisionEnter(Collision collision)
    {
        
        //ChangeMaterial();
        if(collision.gameObject.tag != "Colour")
        {
            Scale = transform.localScale - new Vector3(5, 5, 0);
            //print (collision.gameObject.name);
            //print(gameObject.name);
            //print(Scale);
            transform.localScale = Scale;
           // print(transform.localScale.x);
            CheckDepthOfCut();
            DefineCollision(collision);
            StartParticle();
        }
        

    }


    private void OnCollisionExit(Collision collision)
    {

        Invoke("StopParticle", 5);

    }



    void CheckDepthOfCut()
    {
        nameOfSlice = gameObject.name;

        if (cuttedSlices.ContainsKey(nameOfSlice))
        {
           // print("Exist!");
           // print(cuttedSlices[nameOfSlice]);
            cuttedSlices[nameOfSlice]++;

            if(cuttedSlices[nameOfSlice] < 4)
            {
                ChangeMaterial(cutFirstStage);
            }
            else if (cuttedSlices[nameOfSlice] > 4)
            {
                ChangeMaterial(cutSecondStage);
            }

        }

        //print(nameOfSlice);

        cuttedSlices.Add(nameOfSlice , 1);

        //print(cuttedSlices);

    }

    void ChangeMaterial(Material material)
    {
        gameObject.GetComponent<MeshRenderer>().material = material;
        //print("changed!");
    }


    void DefineCollision(Collision collision)
    {
        particles = collision.gameObject.transform.parent.gameObject.transform.GetChild(1).gameObject;
                                        
    }

    void StartParticle()
    {
        particles.SetActive(true);
    }

    void StopParticle()
    {
       // particles.SetActive(false);
    }







}
