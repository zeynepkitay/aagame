﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int pinCount = 0;

    public Text text;

    void Start()
    {
        pinCount = 0;
    }

    void Update()
    {
        text.text = pinCount.ToString();
    }
}
