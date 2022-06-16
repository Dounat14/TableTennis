using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punktezähler : MonoBehaviour
{
    public GameObject Tisch1;
    public GameObject Tisch2;
    public GameObject Bat1;
    public GameObject Bat2;
    public GameObject Floor;

    private bool tisch1;
    private bool tisch2;
    private bool bat1;
    private bool bat2;
    private bool floor;

    private bool first;

    public float Player1;
    public float Player2;
    private float tisch11;
    private float tisch22;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "table1")
        {
            tisch1 = true;
            if (!first && bat1)
            {
                first = true;
            }
            tisch11++;
        }

        if (collision.gameObject.name == "table2")
        {
            tisch2 = true;
            if (!first && bat2)
            {
                first = true;
            }
            tisch22++;
        }

        if (collision.collider.name == "Bat1")
        {
            if (bat2 && !tisch1 && !tisch2)
            {
                Player2++;
                transform.position = new Vector3(-2, 0, 0);
            }
            bat1 = true;
            bat2 = false;
            tisch1 = false;
            tisch2 = false;
            floor = false;
            
        }

        if (collision.gameObject.name == "Bat2")
        {
            if (bat1 && !tisch1 && !tisch2)
            {
                Player1++;
                transform.position = new Vector3(-2, 0, 0);
            }
            bat2 = true;
            bat1 = false;
            tisch1 = false;
            tisch2 = false;
            floor = false;
        }

        if (collision.gameObject.name == "Floor")
            floor = true;

    }

    void Update()
    {
        Punkte();
    }

    private void Punkte()
    {


        //ist der Ball nach dem erst schlag auf der eigenen und dann der gegner seite gelandet für spieler1
        if (tisch2 && bat1 && floor && first)
        {
            Player1++;
            bat1 = false;
            tisch2 = false;
            floor = false;
            first = false;
            tisch11 = 0;
            tisch22 = 0;
            transform.position = new Vector3(-2, 0, 0);
        }
        //wenn nicht das eigene Feld angespielt worden ist nach dem ersten schlag bekommt spieler 2 den punkt
        if (tisch2 && bat1 && !first)
        {
            Player2++;
            bat1 = false;
            tisch2 = false;
            floor = false;
            first = false;
            tisch11 = 0;
            tisch22 = 0;
            transform.position = new Vector3(-2, 0, 0);
        }
        if (tisch1 && bat1 && first)
        {
            Player2++;
            bat1 = false;
            tisch1 = false;
            first = false;
            floor = false;
            tisch11 = 0;
            tisch22 = 0;
            transform.position = new Vector3(-2, 0, 0);
        }
        //Das selbe wie oben drüber nur für den anderen Spieler
        if (bat2 && tisch1 && first)
        {
            Player2++;
            bat2 = false;
            tisch1 = false;
            floor = false;
            first = false;
            tisch11 = 0;
            tisch22 = 0;
            transform.position = new Vector3(-2, 0, 0);
        }
        if (bat2 && tisch1 && floor && !first)
        {
            Player1++;
            first = false;
            bat2 = false;
            tisch1 = false;
            tisch2 = false;
            floor = false;
            tisch11 = 0;
            tisch22 = 0;
            transform.position = new Vector3(-2, 0, 0);
        }
        //Spiel fehler Player 2
        if (bat2 && floor)
        {
            Player1++;
            first = false;
            bat2 = false;
            tisch1 = false;
            tisch2 = false;
            floor = false;
            tisch11 = 0;
            tisch22 = 0;
            transform.position = new Vector3(-2, 0, 0);
        }
        //Spiel fehler Player 1
        if (bat1 && floor)
        {
            Player2++;
            first = false;
            tisch1 = false;
            tisch2 = false;
            bat1 = false;
            floor = false;
            tisch11 = 0;
            tisch22 = 0;
            transform.position = new Vector3(-2, 0, 0);
        }
        //ist der ball auf der eigenen Seite von Spieler1 zu oft aufgeschlagen
        if (tisch1 && tisch11 > 1)
        {
            Player2++;
            first = false;
            floor = false;
            tisch1 = false;
            tisch2 = false;
            bat1 = false;
            tisch11 = 0;
            tisch22 = 0;
            transform.position = new Vector3(-2, 0, 0);
        }
        //ist der ball auf der eigenen Seite von Spieler2 zu oft aufgeschlagen
        if (tisch2 && tisch22 > 1)
        {
            Player1++;
            first = false;
            floor = false;
            tisch1 = false;
            tisch2 = false;
            bat2 = false;
            tisch22 = 0;
            tisch11 = 0;
            transform.position = new Vector3(-2, 0, 0);
        }
        //Ball only touches the Ground nothing else
        if (floor)
        {
            floor = false;
        }
    }
}
