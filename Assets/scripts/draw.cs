using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw : MonoBehaviour
{
    [SerializeField]
    private Camera cam = null;
    [SerializeField]
    private LineRenderer lineRenderer = null;
    private Vector3 previus_pos;
    private Vector3 mouse_pos;
    private Vector3 pos;
    [SerializeField]
    private List<Vector3> line_pos = new List<Vector3>();
    [SerializeField]
    private float min_dist = 0.05f;
    private float dist = 0;
    
    void Start()
    {
        
    }

    void Update()
    {
                if(Input.GetMouseButtonDown(0))
        {
            line_pos.Clear();
            mouse_pos = Input.mousePosition;
            mouse_pos.z = 10;
            pos = cam.WorldToScreenPoint(mouse_pos);
            previus_pos = pos;
            line_pos.Add(pos);
            

        }
                else
              if (Input.GetMouseButton(0))

        {
            mouse_pos = Input.mousePosition;
            pos = cam.WorldToScreenPoint(mouse_pos);
            dist = Vector3.Distance(pos, previus_pos);
            if(dist >= min_dist)
            {
                previus_pos = pos;
                line_pos.Add(pos);
                lineRenderer.positionCount = line_pos.Count;
                lineRenderer.SetPositions(line_pos.ToArray());



            }

        }
    }
}
