using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenue : MonoBehaviour {

    //Die Panels die jeweils sichtbar und unsichtbar gemacht werden sollen
    public GameObject Hauptmenue, Impressummenue;


    //Wenn auf Level geklickt wurde
    public void OnNeuStarten()
    {
       PlayerPrefs.DeleteAll();
       StartCoroutine(FadeOUT("Frame1"));
    }

    //Wenn auf Level geklickt wurde
    public void OnFortsetzen()
    {
        string scene = PlayerPrefs.GetString("aktuelleSzene");
        SceneManager.LoadScene(scene);
    }



    //Wenn auf Impressum geklickt wurde
    public void OnImpressum(bool clicked)
    {
        if (clicked)
        {
            Impressummenue.SetActive(clicked);
            Hauptmenue.SetActive(!clicked);

        }
        else
        {
            Impressummenue.SetActive(clicked);
            Hauptmenue.SetActive(!clicked);

        }
    }

    public void OnVerlassen()
    {
        Application.Quit();
    }


    IEnumerator FadeOUT(string scene)
    {
        GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);

    }





}
