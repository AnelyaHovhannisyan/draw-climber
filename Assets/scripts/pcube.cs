using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pcube : MonoBehaviour
{

    List<Vector3> vertices;
    List<int> triagles;
    [SerializeField]
    private float scale = 1f;
    float ascale;
    [SerializeField]
    private int posX, posY, posZ;

    private void Awake()
    {
        ascale = scale * 0.5f;
    }
    void Start()
    {
        Mesh mesh = new Mesh();
        MakeCube(ascale, new Vector3((float) posX*scale, (float)posY * scale, (float)posZ * scale));

        mesh.vertices = vertices.ToArray();
        mesh.triangles = triagles.ToArray();
        mesh.RecalculateNormals();

        GameObject gameObject = new GameObject("Mesh", typeof(MeshFilter), typeof(MeshRenderer));
        gameObject.GetComponent<MeshFilter>().mesh = mesh;
    }
    void MakeCube(float cubescale, Vector3 cubepos)
    {
        vertices = new List<Vector3>();
        triagles = new List<int>();
        for (int i = 0; i < 6; i++)
        {
            MakeFace(i, cubescale, cubepos);
        }
    }

    void MakeFace(int dir, float facescale, Vector3 facepos)
    {
        vertices.AddRange(cubemesh.fvertices(dir, facescale, facepos));
        triagles.Add(vertices.Count - 4);
        triagles.Add(vertices.Count - 4 + 1);
        triagles.Add(vertices.Count - 4 + 2);
        triagles.Add(vertices.Count - 4);
        triagles.Add(vertices.Count - 4 + 2);
        triagles.Add(vertices.Count - 4 + 3);


    }

    void Update()
    {

    }

}