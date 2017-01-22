using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class ScreenfertigmitEnte : MonoBehaviour {

    public GameObject haensel, gretel, duck;
    public GameObject text, schrittzaehlerH, schrittzaehlerG, schrittzaehlerD;
    public int schritteEnte, schritteHaensel, schritteGretel;
    private AllTexts allTexts;
    private int zaehlerh, zaehlerg, zaehlerd;
    // Use this for initialization
    void Start()
    {
        allTexts = text.GetComponent<AllTexts>();
        zaehlerh = 0;
        zaehlerg = 0;
        zaehlerd = 0;
        PlayerPrefs.SetString("aktuelleSzene", SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        zaehlerh = schrittzaehlerH.GetComponent<ChCounter>().getZaehler();
        zaehlerg = schrittzaehlerG.GetComponent<ChCounter>().getZaehler();
        zaehlerd = schrittzaehlerD.GetComponent<ChCounter>().getZaehler();
        Debug.Log(zaehlerh);
        Debug.Log(zaehlerg);
        Debug.Log(zaehlerd);
        Debug.Log("C:"+allTexts.getCounter());
        Debug.Log("L:"+allTexts.messages.Length);
        if (allTexts.getCounter() >= allTexts.messages.Length - 1 && !haensel.activeSelf && !gretel.activeSelf && !duck.activeSelf && zaehlerh>=schritteHaensel && zaehlerg>=schritteGretel && zaehlerd>=schritteEnte)
        {
            //Debug.Log(SceneManager.GetActiveScene().name);
            if (SceneManager.GetActiveScene().name == "Frame6a")
            {
                PlayerPrefs.SetString("FRame7", "a");
                StartCoroutine(FadeOUT("FRame7a"));
            }
            if (SceneManager.GetActiveScene().name == "FRame7a")
            {
               // Debug.Log("gehtrein");
                PlayerPrefs.SetString("Frame8", "a");
                StartCoroutine(FadeOUT("Frame8a"));
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
