using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VratiUHodnikSefer : MonoBehaviour
{
    public void vratiMeUHodnik()
    {
        //SceneManager.UnloadScene("Sefer");
        SceneManager.LoadScene("Igra");
    }
}
