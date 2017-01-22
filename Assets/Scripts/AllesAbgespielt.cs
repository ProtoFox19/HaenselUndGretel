using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class AllesAbgespielt : MonoBehaviour {

    public GameObject text, dad, mom;

    private AllTexts allTexts;



    // Use this for initialization
    void Start()
    {
        allTexts = text.GetComponent<AllTexts>();
        PlayerPrefs.SetString("aktuelleSzene", SceneManager.GetActiveScene().name);
       // PlayerPrefs.SetString("zusatz", PlayerPrefs.GetString("Frame4"));

    }

    // Update is called once per frame
    void Update () {
       // Debug.Log("Z:"+zaehler);
       /* Debug.Log("C:" + allTexts.getCounter());
        Debug.Log("L:" + allTexts.messages.Length);
        Debug.Log("D:" + dad.activeSelf);
        Debug.Log("M:" + mom.activeSelf);*/
        if (allTexts.getCounter() >= allTexts.messages.Length - 1 && !dad.activeSelf && !mom.activeSelf)
        {
            //Debug.Log("geht in nächsten Frame");
            string buchstabe = PlayerPrefs.GetString("Frame4");
            PlayerPrefs.SetString("Frame5", buchstabe);
            StartCoroutine(FadeOUT("Frame5"));
        }
	}



        IEnumerator FadeOUT(string scene)
    {
        GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);

    }
}
