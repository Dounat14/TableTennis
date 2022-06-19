using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Punkte : MonoBehaviour
{
    public Punktezähler punktezähler;
    public TMP_Text Player1;
    public TMP_Text Player2;
    public TMP_Text Satz1;
    public TMP_Text Satz2;


    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        Player1.text = punktezähler.Player1.ToString();
        Player2.text = punktezähler.Player2.ToString();
        Satz1.text = punktezähler.Satz1.ToString();
        Satz2.text = punktezähler.Satz2.ToString();
    }
}
