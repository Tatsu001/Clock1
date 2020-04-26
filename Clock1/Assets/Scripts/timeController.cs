using System.Collections.Generic;
using System;   // DateTimeに必要
using System.Collections;
using UnityEngine;

public class timeController : MonoBehaviour {

    public GameObject hour;
    public GameObject minute;

    void Start ()
    {

    }

    void Update ()
    {
        DateTime dt = DateTime.Now;

        hour.transform.eulerAngles = new Vector3(0,0,-180 + (float)dt.Hour/24*-360 + (float)dt.Minute/60*-15);
        minute.transform.eulerAngles = new Vector3(0,0,((float)dt.Hour%6)*-60 + -(float)dt.Minute);
    }
}

