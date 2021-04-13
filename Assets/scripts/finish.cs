using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    //[SerializeField]
    //private GameObject[] levels;
    [SerializeField]
    private GameObject level1;
    [SerializeField]
    private GameObject nextlevel;



    private void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //nextlevel();


            //nextlevel = Instantiate(Resources.Load("levels/level_3") as GameObject);

            nextlevel = Instantiate(Resources.Load("levels/level_2") as GameObject);
            Destroy(level1);




        }
        else
        {
            Destroy(nextlevel);
        }

    }
    //private void nextlevel()

    //{

    //    for (int i = 0; i < levels.Length; i++)
    //    {
    //        //if ()
    //        //{

    //        //}
    //    }
    //}
}

