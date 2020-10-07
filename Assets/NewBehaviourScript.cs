using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Transform>().position.y >13)
            GetComponent<Renderer>().material.color = Color.red;
        if (GetComponent<Transform>().position.y <13)
            GetComponent<Renderer>().material.color = Color.blue;
    }
}
