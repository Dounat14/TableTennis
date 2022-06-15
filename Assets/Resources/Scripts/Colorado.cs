using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorado : MonoBehaviour
{
    public Collider[] colli;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < colli.Length; i++)
        {
            Physics.IgnoreCollision(colli[i], GetComponent<Collider>());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
