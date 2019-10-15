using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monument : MonoBehaviour
{   private UiManager manager;
    
    void Start()
    {
        manager = GameObject.Find("MainCanvas").GetComponent<UiManager>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other)
    {       
        if (other.name == "MapboxAstronaut")
        {   
            manager.ShowPass();
            print ("collided with monument");
        }        
    }
    
}
