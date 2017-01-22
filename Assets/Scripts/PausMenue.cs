using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PausMenue : MonoBehaviour
{

    // Objekte die Versteckt werden muessen, oder sichtbar gemacht werden muessen
    public GameObject Pauseb, Weissesoverlay, Roterrand, Weiterspielen, Neustart;

    //Am Anfang soll der zustand des nicht gedrueckten Pausenbuttons herschen
    public void Start()
    {
     
        OnWeiterspielenButton();
    }

    //Wenn auf den Pausebutton gedrueckt wurde
    public void OnPause()
    {
      
        Weissesoverlay.SetActive(true);     //Mach das Overlay sichtbar
        Roterrand.SetActive(true);
        Pauseb.SetActive(false);            //mach den Pausebutton unsichtbar
        Time.timeScale = 0;                 //halt das Spiel an
        
    }

    //Wenn auf den Weiterspielen Button gedrueckt wurde
    public void OnWeiterspielenButton()
    {
       
        Weissesoverlay.SetActive(false);
        Roterrand.SetActive(false);
        Pauseb.SetActive(true);
        Time.timeScale = 1;
    }

    //Fuer ein neustart laed er die Szene einfach neu
    public void OnSpeichernUndZumHauptmenue()
    {
        //PlayerPrefs();
        Time.timeScale = 1;
        SceneManager.LoadScene("Menue");
    }


}