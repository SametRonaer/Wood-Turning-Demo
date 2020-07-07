using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareWoods : MonoBehaviour
{
    [SerializeField]
    GameObject modelMesh;
    float modelX, modelY, cuttedX, cuttedY;
    float accuracy , percentage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        percentage = 0f;
        Compare();
    }


    void Compare()
    {
        accuracy = 0;

        for (int i = 0; 305>i; i++)
        {
            cuttedX = gameObject.transform.GetChild(i).transform.localScale.x;
            cuttedY = gameObject.transform.GetChild(i).transform.localScale.y;
            modelX = modelMesh.transform.GetChild(i).transform.localScale.x;
            modelY = modelMesh.transform.GetChild(i).transform.localScale.y;

          

            if (((modelX+6)>cuttedX)  && (modelX-6)<cuttedX)
            accuracy ++;




        }

        percentage = (accuracy/305)*100;
        //if(percentage> 43.2)
        print("Similarity Ratio:"+percentage+"%");
       
    }


}
