using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spray : MonoBehaviour
{
    bool particleActive = false;
    Animator animator;
    Animation animation;
    bool backPlay;
    [SerializeField]
    GameObject plane;
    bool changeColour;
    [SerializeField]
    GameObject cam;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animation = GetComponent<Animation>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            if (backPlay)
            {
                SprayActive();
            }
            
        }


       

    }

    private void OnMouseDown()
    {
        //print(gameObject.name);
        if(gameObject.name == "Blue Spray")
        {
            AnimateSprays("Blue" , "BlueBack");
        }
       else if(gameObject.name == "Purple Spray")
        {
            AnimateSprays("Purple", "PurpleBack");
        }
        else
        {
            AnimateSprays("Green", "GreenBack");
        }



    }


    void SprayActive()
    {
        if (!particleActive)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            //print(transform.parent.GetChild(0).gameObject.name);
            particleActive = true;
        }
        else
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
           
            particleActive = false;
            // print(transform.parent.GetChild(0).gameObject.name);
        }
    }


    void AnimateSprays(string animate , string animateBack)
    {
        if (!backPlay)
        {
            animator.SetTrigger(animate);
           // print("click!");
           // print(gameObject.transform.GetChild(0).gameObject.name);
            backPlay = true;
        }
        else
        {

            animator.SetTrigger(animateBack);
            backPlay = false;
        }
    }


}
