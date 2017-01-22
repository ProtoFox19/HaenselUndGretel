using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ScreenfertigHaenselundGretel : MonoBehaviour {
    public GameObject haensel, gretel;
    public GameObject text, schrittzaehlerH, schrittzaehlerG;
    private AllTexts allTexts;
    private int zaehlerh, zaehlerg;
    // Use this for initialization
    void Start()
    {
        allTexts = text.GetComponent<AllTexts>();
        zaehlerh = 0;
        zaehlerg = 0;
        PlayerPrefs.SetString("aktuelleSzene", SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        zaehlerh = schrittzaehlerH.GetComponent<ChCounter>().getZaehler();
        zaehlerg = schrittzaehlerG.GetComponent<ChCounter>().getZaehler();

       /* Debug.Log(zaehlerh);
        Debug.Log(zaehlerg);

        Debug.Log("C:" + allTexts.getCounter());
        Debug.Log("L:" + allTexts.messages.Length);*/
        if (allTexts.getCounter() >= allTexts.messages.Length - 1 && !haensel.activeSelf && !gretel.activeSelf && zaehlerh >= 1 && zaehlerg >= 1)
        {

            string buchstabe = PlayerPrefs.GetString("Frame3");
            if(buchstabe == "c")
            {
                if(SceneManager.GetActiveScene().name == "Frame10")
                {
                    PlayerPrefs.DeleteAll();
                    StartCoroutine(FadeOUT("Frame11"));
                }
                else
                {
                    PlayerPrefs.SetString("Frame10", buchstabe);
                    StartCoroutine(FadeOUT("Frame10"));
                }
                
            }


            if (SceneManager.GetActiveScene().name == "Frame6b")
            {
                PlayerPrefs.SetString("Frame7", "b");
                StartCoroutine(FadeOUT("Frame7b"));
            }
            if (SceneManager.GetActiveScene().name == "Frame7b")
            {
                //Debug.Log("gehtrein");
                PlayerPrefs.SetString("Frame8", "b");
                StartCoroutine(FadeOUT("Frame8b"));
            }

        }
    }



    IEnumerator FadeOUT(string scene)
    {
        GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(scene);

    }


}