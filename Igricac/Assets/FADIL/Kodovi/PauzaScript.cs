using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauzaScript : MonoBehaviour
{
    public static bool daLiJePauziran = false;

    public GameObject PanelPause;
    public GameObject PanelRangLista;

    public Text DioZaNickname;
    public Text DioZaObjekte;
    public Text DioZaVrijeme;

    public static bool nadjenItem1 = true;
    public static bool nadjenItem2 = true;
    public static bool nadjenItem3 = true;
    public static bool nadjenItem4 = true;
    public static bool nadjenItem5 = true;

    public static int brojacItema;
    public static string stringABC = "NICKNAME";

    void Start()
    {
        Debug.Log("Da udjete u neku sobu desni klik kada pridjete vratima. Ukoliko se nadje item soba se zakljuca");
    }
    // Update is called once per frame
    void Update()
    {
        //DioZaVrijeme.text = Time.time.ToString();
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (daLiJePauziran.Equals(true))
            {
                Nastavi();
            }
            else
            {
                Pauziraj();
            }
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        //fale uslovi za items i fale uslovi za koja je soba
        if (Input.GetMouseButtonDown(0))
        {
            //SceneManager.LoadScene("Igra");
        }
    }

    public void Nastavi()
    {
        PanelPause.SetActive(false);
        PanelRangLista.SetActive(false);
        Time.timeScale = 1f;
        daLiJePauziran = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Pauziraj()
    {
        PanelPause.SetActive(true);
        Time.timeScale = 0f;
        daLiJePauziran = true;
        DioZaVrijeme.text = Time.time.ToString();
        DioZaNickname.text = stringABC;
        brojacItema = 0;
        if (!nadjenItem1) brojacItema++;
        if (!nadjenItem2) brojacItema++;
        if (!nadjenItem3) brojacItema++;
        if (!nadjenItem4) brojacItema++;
        if (!nadjenItem5) brojacItema++;
        DioZaObjekte.text = brojacItema + " / 4";
    }


    public void ClickRangListaPanelPause()
    {
        PanelRangLista.SetActive(true);
        PanelPause.SetActive(false);
    }


    public void ClickNazadPanelRangLista()
    {
        PanelPause.SetActive(true);
        PanelRangLista.SetActive(false);
    }

    public void ClickLogOutPanelPause()
    {
        PocetakIgreScript.daLiJeLogovan = false;
        daLiJePauziran = false;
        //SceneManager.UnloadScene("Igra");
        SceneManager.LoadScene("Pocetak");
    }
}
