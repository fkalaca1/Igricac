using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VratiUHodnikSamra : MonoBehaviour
{
    public void vratiMeUHodnik()
    {
        //SceneManager.UnloadScene("Meni");
        //SceneManager.UnloadScene("SampleScene");
        //SceneManager.UnloadScene("zavrsna");
        SceneManager.LoadScene("Igra");
    }
}
