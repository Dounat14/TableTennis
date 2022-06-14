using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorado : MonoBehaviour
{
    public Collider[] collider;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < collider.Length; i++)
        {
            Physics.IgnoreCollision(collider[i], GetComponent<Collider>());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
