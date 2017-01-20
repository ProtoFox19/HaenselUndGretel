using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;



public class AllTexts : MonoBehaviour {



	private Text text;

	public string [] messages;

	[Header("Speakers. Gretel = 1, Haensel = 2")]
	[Header("mom  = 3, dad = 4, duck = 5")]

	public float [] speaker;

	private int counter = 0;

	private int speakerCounter = 0;


    public GameObject haenselSpeaker; // 2

    public GameObject gretelSpeaker; // 1

    public GameObject momSpeaker; // 3

    public GameObject dadSpeaker; // 4

    public GameObject duckSpeaker; // 5

    public GameObject haenselWalk; // 2

    public GameObject gretelWalk; // 1

    public GameObject momWalk; // 3

    public GameObject dadWalk; // 4

    public GameObject duckWalk; // 5


    public GameObject [] speakingCheckpoints;




	// Use this for initialization
	void Start () {

		text = GetComponent<Text> ();

	}

	public float currentSpeaker () {

		return speaker [speakerCounter];
	}

	public void countSpeaker () {

		speakerCounter++;
	}

	// Update is called once per frame
	void Update () {
		text.text = messages [counter];
	}

	public void count () {
        counter++;

        if(counter >= messages.Length-1)
        {
             haenselSpeaker.SetActive(false); 

             gretelSpeaker.SetActive(false); 

             momSpeaker.SetActive(false);

            dadSpeaker.SetActive(false);

            duckSpeaker.SetActive(false);

            haenselWalk.SetActive(true);
            gretelWalk.SetActive(true);

            momWalk.SetActive(true);

            dadWalk.SetActive(true);

            duckWalk.SetActive(true);
        }
    }

	public int getCounter () {

		return counter;
	}
}
