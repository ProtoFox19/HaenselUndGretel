using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class AllTextsStatic : MonoBehaviour {



	private Text text;

	public string [] messages;

	[Header("Speakers. Gretel = 1, Haensel = 2")]
	[Header("mom  = 3, dad = 4, duck = 5")]

	public float [] speaker;

	private int counter = -1;

	private int speakerCounter = 0;
	private int spek;

	//public bool naechsteSzene = false;

	public GameObject haenselSpeaker; // 2

	public GameObject gretelSpeaker; // 1


	//public GameObject [] speakingCheckpoints;




	// Use this for initialization
	void Start () {

		text = GetComponent<Text> ();
		spek = 0;
        PlayerPrefs.SetString("aktuelleSzene", SceneManager.GetActiveScene().name);


        Debug.Log(PlayerPrefs.GetInt("zaehler"));

    }

	public float currentSpeaker () {

		return speaker [spek];      
	}

	public void countSpeaker (int spe) {
		if (spe >= messages.Length) {
			counter++;

		}else { 
			spek = spe;
			//speakerCounter++;
			counter++;
			/*Debug.Log("---------------");
			Debug.Log("AllTextsSpe:"+spek);
			Debug.Log("Counter:" + counter);
			Debug.Log("Speaker:" + speaker[spek]);
			Debug.Log("----------------");*/
		}
	}

	// Update is called once per frame
	void Update () {


		if (counter == -1) {
		} else {
			text.text = messages [counter];
		}

		if (currentSpeaker () == 1) {


			gretelSpeaker.SetActive (true);
			haenselSpeaker.SetActive (false);



		}

		// Aktiviere haensel, wenn spricht
		if (currentSpeaker () == 2) {


			haenselSpeaker.SetActive (true);
			gretelSpeaker.SetActive (false);



		}


		if (counter >= messages.Length - 1) {

           // Debug.Log("geht hier rein");
			haenselSpeaker.SetActive (false);

			gretelSpeaker.SetActive (false);

            if (SceneManager.GetActiveScene().name == "Frame1")
            {
                PlayerPrefs.SetInt("zaehler", 0);
                PlayerPrefs.SetString("Frame2", "Frame2");
                StartCoroutine(FadeOUT("Frame2"));
            }

            if (SceneManager.GetActiveScene().name == "Frame5")
            {
                //Debug.Log("geht hier rein");
                if (PlayerPrefs.GetString("Frame3") == "a")
                {
                    PlayerPrefs.SetString("Frame6", "a");
                    StartCoroutine(FadeOUT("Frame6a"));
                }
                if (PlayerPrefs.GetString("Frame3") == "b")
                {
                    //Debug.Log("gehthierein");
                    PlayerPrefs.SetString("Frame6", "b");
                    StartCoroutine(FadeOUT("Frame6b"));
                }
                if (PlayerPrefs.GetString("Frame3") == "c")
                {
                    PlayerPrefs.SetString("Frame6", "c");
                    StartCoroutine(FadeOUT("Frame6c"));
                }

            }

            if (SceneManager.GetActiveScene().name == "Frame8a")
            {
                PlayerPrefs.SetString("Frame9", "a");
                StartCoroutine(FadeOUT("Frame9a"));
            }

            if (SceneManager.GetActiveScene().name == "Frame8b")
            {
                PlayerPrefs.SetString("Frame9", "b");
                StartCoroutine(FadeOUT("Frame9b"));
            }

            if (SceneManager.GetActiveScene().name == "Frame9a")
            {
                int zaehler = PlayerPrefs.GetInt("zaehler");
                if (zaehler >= 2)
                {
                    PlayerPrefs.SetString("Frame2", "c");
                    StartCoroutine(FadeOUT("Frame2c"));
                }else
                {
                    PlayerPrefs.SetString("Frame2", "a");
                    StartCoroutine(FadeOUT("Frame2a"));
                }
                
                
            }
            if (SceneManager.GetActiveScene().name == "Frame9b")
            {
                int zaehler = PlayerPrefs.GetInt("zaehler");
                if (zaehler >= 2)
                {
                    PlayerPrefs.SetString("Frame2", "c");
                    StartCoroutine(FadeOUT("Frame2c"));
                }
                else
                {
                    PlayerPrefs.SetString("Frame2", "b");
                    StartCoroutine(FadeOUT("Frame2b"));
                }
            }
        }

	}

    IEnumerator FadeOUT(string scene)
    {
        GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);

    }



    public int getCounter () {

		return counter;
	}
}
