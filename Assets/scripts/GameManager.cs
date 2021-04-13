using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int currentlevel = 0;
    
   public static GameManager singleton;

    private void Awake()
    {
        if (singleton == null)
            singleton = this;
        else if (singleton != this)
            Destroy(gameObject);
    }

    public void next_level()
    {
        currentlevel++;
      
        Debug.Log("next level");
    }
    void Update()
    {
        
    }
}
