using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;



public class AllTextsStatic : MonoBehaviour {



	private Text text;

	public string [] messages;

	[Header("Speakers. Gretel = 1, Haensel = 2")]
	[Header("mom  = 3, dad = 4, duck = 5")]

	public float [] speaker;

	private int counter = -1;

	private int speakerCounter = 0;
	private int spek;

	public bool naechsteSzene = false;

	public GameObject haenselSpeaker; // 2

	public GameObject gretelSpeaker; // 1


	//public GameObject [] speakingCheckpoints;




	// Use this for initialization
	void Start () {

		text = GetComponent<Text> ();
		spek = 0;       

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
			Debug.Log("---------------");
			Debug.Log("AllTextsSpe:"+spek);
			Debug.Log("Counter:" + counter);
			Debug.Log("Speaker:" + speaker[spek]);
			Debug.Log("----------------");
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
			naechsteSzene = true;

			haenselSpeaker.SetActive (false);

			gretelSpeaker.SetActive (false);

		}

	}





	public int getCounter () {

		return counter;
	}
}
