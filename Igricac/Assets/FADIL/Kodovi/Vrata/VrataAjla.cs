﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VrataAjla : MonoBehaviour
{
    public void OnCollisionStay(Collision collision)
    {
        //fale uslovi za items i fale uslovi za koja je soba
        if (Input.GetMouseButtonDown(0))
        {
            //SceneManager.UnloadScene("Igra");
            if (PauzaScript.nadjenItem5) SceneManager.LoadScene("17691");
            else Debug.Log("Vec nasao item");
            
        }
    }
}
