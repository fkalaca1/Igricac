﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerAjdin : MonoBehaviour
{
	public Text counterText;
	public float seconds, minutes;
	public Light light;
    // Start is called before the first frame update
    void Start()
    {
		light.enabled = false;
        counterText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        minutes = (int)(Time.time/60f);
		seconds = (int)(Time.time%60f);
		counterText.text = minutes.ToString("00")+":"+seconds.ToString("00");
		
		if(minutes >= 5f){
			light.enabled = true;
		}
    }
}
