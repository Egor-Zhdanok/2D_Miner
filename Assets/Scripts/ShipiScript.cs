﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipiScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
    {
	Debug.Log("Дед наступил на шишпы и теперь на небесах " );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
