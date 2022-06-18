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
            tisch11++;
            tisch1 = true;
            if (first && bat1)
            {
                Player2++;
                bat1 = false;
                tisch1 = false;
                tisch2 = false;
                bat2 = false;
                floor = false;
                first = false;
                tisch22 = 0;
                tisch11 = 0;
                transform.position = new Vector3(2, (float)0.2, (float)-0.015);
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            if (!first && bat1)
            {
                first = true;
            }
            if (!first && bat2)
            {
                Player1++;
                bat1 = false;
                tisch1 = false;
                tisch2 = false;
                bat2 = false;
                floor = false;
                first = false;
                tisch22 = 0;
                tisch11 = 0;
                transform.position = new Vector3(-2, (float)0.2, (float)-0.015);
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            if (tisch11 > 1 && (bat1 || bat2))
            {
                Player2++;
                bat1 = false;
                tisch1 = false;
                tisch2 = false;
                bat2 = false;
                floor = false;
                first = false;
                tisch22 = 0;
                tisch11 = 0;
                transform.position = new Vector3(2, (float)0.2, (float)-0.015);
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
        }

        if (collision.gameObject.name == "table2")
        {
            tisch22++;
            tisch2 = true;
            if (first && bat2)
            {
                Player1++;
                bat1 = false;
                tisch1 = false;
                tisch2 = false;
                bat2 = false;
                floor = false;
                first = false;
                tisch22 = 0;
                tisch11 = 0;
                transform.position = new Vector3(-2, (float)0.2, (float)-0.015);
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            if (!first && bat2)
            {
                first = true;
            }
            if (!first && bat1)
            {
                Player2++;
                bat1 = false;
                tisch1 = false;
                tisch2 = false;
                bat2 = false;
                floor = false;
                first = false;
                tisch22 = 0;
                tisch11 = 0;
                transform.position = new Vector3(2, (float)0.2, (float)-0.015);
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            if (tisch22 > 1 && (bat1 || bat2))
            {
                Player1++;
                bat1 = false;
                tisch1 = false;
                tisch2 = false;
                bat2 = false;
                floor = false;
                first = false;
                tisch22 = 0;
                tisch11 = 0;
                transform.position = new Vector3(-2, (float)0.2, (float)-0.015);
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
        }
        if (collision.gameObject.name == "Bat1")
        {
            bat1 = true;
            if (first && !tisch1 && !tisch2)
            {
                Player2++;
                bat1 = false;
                first = false;
                transform.position = new Vector3(2, (float)0.2, (float)-0.015);
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            floor = false;
            tisch1 = false;
            tisch2 = false;
            bat2 = false;
            tisch22 = 0;
            tisch11 = 0;
        }
        if (collision.gameObject.name == "Bat2")
        {
            bat2 = true;
            if (first && !tisch1 && !tisch2)
            {
                Player1++;
                bat2 = false;
                first = false;
                transform.position = new Vector3(-2, (float)0.2, (float)-0.015);
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            floor = false;
            tisch1 = false;
            tisch2 = false;
            bat1 = false;
            tisch22 = 0;
            tisch11 = 0;
        }
        if (collision.gameObject.name == "Floor")
        {
            floor = true;
        }
    }

    void Update()
    {
        Punkte();
    }

    private void Punkte()
    {
        //Erfolgreicher Schlag auf zweite platte nach Schlag 
        if (bat1 && first && tisch2 && floor)
        {
            Player1++;
            bat1 = false;
            tisch1 = false;
            tisch2 = false;
            bat2 = false;
            floor = false;
            first = false;
            tisch22 = 0;
            tisch11 = 0;
            transform.position = new Vector3(-2, (float)0.2, (float)-0.015);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        if (bat2 && first && tisch1 && floor)
        {
            Player2++;
            bat1 = false;
            tisch1 = false;
            tisch2 = false;
            bat2 = false;
            floor = false;
            first = false;
            tisch22 = 0;
            tisch11 = 0;
            transform.position = new Vector3(2, (float)0.2, (float)-0.015);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        //Spielfehler ohne Platte zu treffen
        if (bat1 && floor)
        {
            Player2++;
            bat1 = false;
            tisch1 = false;
            tisch2 = false;
            bat2 = false;
            floor = false;
            first = false;
            tisch22 = 0;
            tisch11 = 0;
            transform.position = new Vector3(2, (float)0.2, (float)-0.015);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        if (bat2 && floor)
        {
            Player1++;
            bat1 = false;
            tisch1 = false;
            tisch2 = false;
            bat2 = false;
            floor = false;
            first = false;
            tisch22 = 0;
            tisch11 = 0;
            transform.position = new Vector3(-2, (float)0.2, (float)-0.015);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}
