using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public GameObject Bat;
    public bool first = false;
    public Material color;
    public void Vorne()
    {
        Bat.transform.Rotate(0, -180, 0);
    }
    public void Hinten()
    {
        Bat.transform.Rotate(0, 180, 0);
    }
}
