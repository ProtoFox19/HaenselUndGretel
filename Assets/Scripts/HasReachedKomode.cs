using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HasReachedKomode : MonoBehaviour {

    public GameObject murmeln_s, kiesel_s, brot_s, haensel, murmeln, kiesel, brot;

    public GameObject text;

    private AllTexts allTexts;


    // Use this for initialization
    void Start () {
        allTexts = text.GetComponent<AllTexts>();
        PlayerPrefs.SetString("aktuelleSzene", SceneManager.GetActiveScene().name);
        Debug.Log(PlayerPrefs.GetInt("zaehler"));
    }
	
	// Update is called once per frame
	void Update () {
        isAmEnde();
	}

    public void isAmEnde()
    {
        if (haensel.GetComponent<PlayerController>().getReachedEnd() && allTexts.getCounter() >= allTexts.messages.Length - 1)
        {
           /* Debug.Log("HE:"+haensel.GetComponent<PlayerController>().getReachedEnd());
            Debug.Log("C:" + allTexts.getCounter());
            Debug.Log("L:" + allTexts.messages.Length);*/
            if (murmeln_s.activeSelf == false)
            {}else
            {
                murmeln.SetActive(true);
            }

            if (kiesel_s.activeSelf == false)
            {}
            else
            {
                kiesel.SetActive(true);
            }
            if (brot_s.activeSelf == false)
            { }
            else
            {
                brot.SetActive(true);
            }

            murmeln_s.SetActive(false);
            kiesel_s.SetActive(false);
            brot_s.SetActive(false);
            
           // brot.SetActive(true);
           // Debug.Log("istaktiv");
        }
    }

  

    public void onClickMurmeln()
    {

        int zaehler = PlayerPrefs.GetInt("zaehler");
       // Debug.Log("ZOC:"+zaehler);
        int neu = zaehler + 1;
        PlayerPrefs.SetInt("zaehler", neu);

        PlayerPrefs.SetString("Frame3", "a");

        murmeln.SetActive(false);
        StartCoroutine(FadeOUT("Frame3a"));
    }

    public void onClickSteine()
    {
        int zaehler = PlayerPrefs.GetInt("zaehler");
      //  Debug.Log("ZOC:" + zaehler);
        int neu = zaehler + 1;
        PlayerPrefs.SetInt("zaehler", neu);

        PlayerPrefs.SetString("Frame3", "b");

        kiesel.SetActive(false);
        StartCoroutine(FadeOUT("Frame3b"));
    }

    public void onClickBrot()
    {
        PlayerPrefs.SetString("Frame3", "c");

        brot.SetActive(false);
        StartCoroutine(FadeOUT("Frames3c"));
    }


    IEnumerator FadeOUT(string scene)
    {
        GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);
        
    }
}
