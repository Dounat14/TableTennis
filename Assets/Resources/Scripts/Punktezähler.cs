using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punktezähler : MonoBehaviour
{
    public GameObject Tisch1;
    public GameObject Tisch2;
    public GameObject Bat;
    public GameObject Bat1;
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

        if (collision.collider.name == "bat")
            bat1 = true;

        if (collision.gameObject.name == "bat1")
            bat2 = true;

        if (collision.gameObject.name == "floor")
            floor = true;

    }

    void Update()
    {
        Punkte();
    }

    private void Punkte()
    {
        //ist der ball auf der eigenen Seite von Spieler1 zu oft aufgeschlagen
        if (tisch1 && bat1 && tisch11 > 1)
        {
            Player2++;
            first = false;
        }
        //ist der ball auf der eigenen Seite von Spieler2 zu oft aufgeschlagen
        if (tisch2 && bat2 && tisch22 > 1)
        {
            Player1++;
            first = false;
        }
        //ist der ball auf der Gegner seite zu oft aufgeschlagen
        if (tisch2 && bat1 && tisch22 > 1)
        {
            Player1++;
            first = false;
        }
        //ist der Ball auf der Gegner seite zu oft aufgeschalgen
        if (tisch1 && bat2 && tisch11 > 1)
        {
            Player2++;
            first = false;
        }
        //ist der Ball nach dem erst schlag auf der eigenen und dann der gegner seite gelandet für spieler1
        if (tisch2 && bat1 && floor && first)
        {
            Player1++;
            first = false;
        }
        //wenn nicht das eigene Feld angespielt worden ist nach dem ersten schlag bekommt spieler 2 den punkt
        if (tisch2 && bat1 && floor && !first)
        {
            Player2++;
            first = false;
        }
        //Das selbe wie oben drüber nur für den anderen Spieler
        if (bat2 && tisch1 && floor && first)
        {
            Player2++;
            first = false;
        }
        if (bat2 && tisch1 && floor && !first)
        {
            Player1++;
            first = false;
        }
        //Spiel fehler 
        if (bat2 && floor)
        {
            Player1++;
            first = false;
        }
        if (bat1 && floor)
        {
            Player2++;
            first = false;
        }
    }
}
