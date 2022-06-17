using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punktezähler : MonoBehaviour
{
    private bool tisch1;
    private bool tisch2;
    private bool bat1;
    private bool bat2;
    private bool floor;
    private bool first;

    public float Player1;
    public float Player2;
    public float tisch11;
    public float tisch22;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "table1")
        {
            tisch1 = true;
            if (first && bat1)
            {
                Player2++;
            }
            if (!first && bat1)
            {
                first = true;
            }
            tisch11++;
            if (tisch11 > 1 && (bat1 || bat2))
            {
                Player2++;
            }
        }

        if (collision.gameObject.name == "table2")
        {
            tisch2 = true;
            if (first && bat2)
            {
                Player1++;
            }
            if (!first && bat2)
            {
                first = true;
            }
            tisch22++;
            if (tisch22 > 1 && (bat1 || bat2))
            {
                Player1++;
            }
        }
        if (collision.gameObject.name == "Bat1")
        {

        }
    }

    void Update()
    {
        Punkte();
    }

    private void Punkte()
    {

    }
}
