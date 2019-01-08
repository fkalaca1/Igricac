using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VratiUHodnikAjdin : MonoBehaviour
{
    public void vratiMeUHodnik()
    {
        //SceneManager.UnloadScene("Ajdin");
        SceneManager.LoadScene("Igra");
    }
}
