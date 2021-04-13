using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxcreate : MonoBehaviour
{
    [SerializeField]
    private Material material;
 

    void Start()
    {
        Vector3[] vertices = new Vector3[4];
        Vector2[] uv = new Vector2[4];
        Vector3[] normals = new Vector3[4];
        int[] traingles = new int[6];

        //vertices[0] = new Vector3(0, 1);
        //vertices[1] = new Vector3(1, 1);
        //vertices[2] = new Vector3(0, 0);
        //vertices[3] = new Vector3(1, 0);
        vertices[0] = new Vector3(0, 0,0);
        vertices[1] = new Vector3(0,0,1);
        vertices[2] = new Vector3(1,0,0);
        vertices[3] = new Vector3(1, 0,1);
        

        normals[0] = -Vector3.forward;
        normals[1] = -Vector3.forward;
        normals[2] = -Vector3.forward;
        normals[3] = -Vector3.forward;


        uv[0] = new Vector2(0, 1);
        uv[1] = new Vector2(1, 1);
        uv[2] = new Vector2(0, 0);
        uv[3] = new Vector2(1, 0);

        traingles[0] = 0;
        traingles[1] = 1;
        traingles[2] = 2;
        traingles[3] = 2;
        traingles[4] = 1;
        traingles[5] = 3;


        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = traingles;
        mesh.normals = normals;

        GameObject gameObject = new GameObject("New_Mesh", typeof(MeshFilter), typeof(MeshRenderer));
        gameObject.GetComponent<MeshFilter>().mesh = mesh;
        gameObject.GetComponent<MeshRenderer>().material = material;

    }

    
    void Update()
    {
        
    }
}
