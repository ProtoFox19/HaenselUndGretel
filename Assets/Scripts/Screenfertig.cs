using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Screenfertig : MonoBehaviour {

    public GameObject haensel, gretel, mom, dad;
    public GameObject text;
    public GameObject steinzaehler;
    private AllTexts allTexts;
    private int zaehler=0;
    // Use this for initialization
    void Start () {
        allTexts = text.GetComponent<AllTexts>();
        zaehler = 0;
        PlayerPrefs.SetString("aktuelleSzene", SceneManager.GetActiveScene().name);
    }
	
	// Update is called once per frame
	void Update () {
        zaehler = steinzaehler.GetComponent<WegPunktthings>().getZaehler();
        //Debug.Log(zaehler);
        if (allTexts.getCounter() >= allTexts.messages.Length - 1 && !haensel.activeSelf && !gretel.activeSelf && !dad.activeSelf && !mom.activeSelf && zaehler>=5)
        {
            Debug.Log("geht in nächsten Frame");
            string buchstabe = PlayerPrefs.GetString("Frame3");
            PlayerPrefs.SetString("Frame4", buchstabe);
            StartCoroutine(FadeOUT("Frame4"));
        }
    }



    IEnumerator FadeOUT(string scene)
    {
        GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);

    }


}
