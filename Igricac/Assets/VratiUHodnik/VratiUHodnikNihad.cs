using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VratiUHodnikNihad : MonoBehaviour
{
    public void vratiMeUHodnik()
    {
        //SceneManager.UnloadScene("Nihad");
        SceneManager.LoadScene("Igra");
    }
}
