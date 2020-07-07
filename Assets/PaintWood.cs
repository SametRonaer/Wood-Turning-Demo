using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintWood : MonoBehaviour
{
    [SerializeField]
    GameObject game;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray , out hit , 1000f))
            {
                //print(hit.triangleIndex);
                deleteTri(hit.triangleIndex);
               
            }
        }
    }


    void deleteTri(int index)
    {
        Destroy(this.gameObject.GetComponent<MeshCollider>());
        Mesh mesh = transform.GetComponent<MeshFilter>().mesh;
        int[] oldTriangles = mesh.triangles;
        //print(oldTriangles[1]);
       // print(oldTriangles.Length);
        int[] newTriangles = new int[mesh.triangles.Length - 3 ];
        int i = 0;
        int j = 0;
        while(j< mesh.triangles.Length)
        {
            if(j != index*3)
            {
                newTriangles[i++] = oldTriangles[j++];
                newTriangles[i++] = oldTriangles[j++];
                newTriangles[i++] = oldTriangles[j++];
            }
            else
            {
                ChangeMeshColor(j+3);
                newTriangles[i++] = oldTriangles[j++];
                newTriangles[i++] = oldTriangles[j++];
                newTriangles[i++] = oldTriangles[j++];

               j += 3;
            }
        }
        transform.GetComponent<MeshFilter>().mesh.triangles = newTriangles;
        this.gameObject.AddComponent<MeshCollider>();
    }


    




    void ChangeMeshColor(int j)
    {
        Mesh mesh = this.gameObject.GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;

        // create new colors array where the colors will be created.
        Color[] colors = new Color[vertices.Length];

        for (int i = 0; i < vertices.Length; i++)
            if (i == j)
            {
                colors[j] = Color.blue;
            }
            else
            {
                colors[i] = Color.white;
            }
            

        // assign the array of colors to the Mesh.
        mesh.colors = colors;
    }



}