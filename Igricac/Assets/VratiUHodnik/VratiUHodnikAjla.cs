using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VratiUHodnikAjla : MonoBehaviour
{
    public void vratiMeUHodnik()
    {
        //SceneManager.UnloadScene("Ajla");
        SceneManager.LoadScene("Igra");
    }
}
