using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenue : MonoBehaviour {

    //Die Panels die jeweils sichtbar und unsichtbar gemacht werden sollen
    public GameObject Hauptmenue, Optionenmenue, Impressummenue;


    //Wenn auf Level geklickt wurde
    public void OnNeuStarten(bool clicked)
    {
       
        if (clicked)
        {

        }
        else
        {

        }
    }

    //Wenn auf Level geklickt wurde
    public void OnFortsetzen(bool clicked)
    {

        if (clicked)
        {

        }
        else
        {

        }
    }

    //Wenn auf Obtionen geklickt wurde
    public void OnOptionen(bool clicked)
    {
        if (clicked)
        {
            Optionenmenue.SetActive(clicked);        //wird das OptionsmenuePanel sichtbar gemacht
            Hauptmenue.SetActive(!clicked);          //wird das HauptmenuePanel unsichtbar gemacht
            Impressummenue.SetActive(!clicked);

        }
        else
        {
            Optionenmenue.SetActive(clicked);
            Hauptmenue.SetActive(!clicked);
            Impressummenue.SetActive(clicked);

        }
    }

    //Wenn auf Impressum geklickt wurde
    public void OnImpressum(bool clicked)
    {
        if (clicked)
        {
            Impressummenue.SetActive(clicked);
            Hauptmenue.SetActive(!clicked);
            Optionenmenue.SetActive(!clicked);

        }
        else
        {
            Impressummenue.SetActive(clicked);
            Hauptmenue.SetActive(!clicked);
            Optionenmenue.SetActive(clicked);

        }
    }

    public void OnVerlassen()
    {
        Application.Quit();
    }




    public void OnZuruecksetzen(bool clicked)
    {
        if (clicked)
        {
            PlayerPrefs.DeleteAll();
            Optionenmenue.SetActive(!clicked);
            Hauptmenue.SetActive(clicked);
            Impressummenue.SetActive(!clicked);

            SceneManager.LoadScene(0);
        }
    }



}
