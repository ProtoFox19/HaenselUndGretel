using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class WegPunktthings : MonoBehaviour {


    public GameObject thing1, thing2, thing3, thing4, thing5;
   // public GameObject text;
   // public GameObject haensel, gretel, mom, dad;
   // private AllTexts allTexts;
    // Use this for initialization
    private int zaehler = 0;
    private GameObject[] thingarray = new GameObject[5];
    void Start () {
        thingarray[0] = thing1;
        thingarray[1] = thing2;
        thingarray[2] = thing3;
        thingarray[3] = thing4;
        thingarray[4] = thing5;

     //   allTexts = text.GetComponent<AllTexts>();
    }
	
	// Update is called once per frame
	void Update () {
        /*  Debug.Log("Z:"+zaehler);
          Debug.Log("C:" + allTexts.getCounter());
          Debug.Log("L:" + allTexts.messages.Length);
          Debug.Log("HE:" + haensel.GetComponent<PlayerController>().getReachedEnd());
          Debug.Log("GE:" + gretel.GetComponent<PlayerController>().getReachedEnd());
          Debug.Log("ME:" + mom.GetComponent<PlayerController>().getReachedEnd());
          Debug.Log("DE:" + dad.GetComponent<PlayerController>().getReachedEnd());
          */
      /*  if (zaehler>=4 && allTexts.getCounter() >= allTexts.messages.Length - 1)
        {
            Debug.Log("gehtrein");
            string buchstabe = PlayerPrefs.GetString("Frame3");
            PlayerPrefs.SetString("Frame4", buchstabe);
            StartCoroutine(FadeOUT("Frame4"));
        }*/
	}

    private void OnMouseDown()
    {
        
        thingarray[zaehler].SetActive(true);
        zaehler++;

    }

    public int getZaehler()
    {
        return zaehler;
    }


   /* IEnumerator FadeOUT(string scene)
    {
        GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);

    }*/
}
