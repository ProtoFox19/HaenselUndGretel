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

		if (counter < messages.Length) {

			text.text = messages [counter];

			counter ++;
		}
	}

	public int getCounter () {

		return counter;
	}
}
