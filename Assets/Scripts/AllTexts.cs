using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class AllTexts : MonoBehaviour {


	// Scene 1

	public string welcome = "Benutze das Steuerkreuz zur Bewegung ... ";

	public string move = "... Nehme dir ein wenig Zeit, dich umzuschauen";

	public string where = "Du befindest dich gerade in einem Traum";

	public string live = "Deine Spielerfigur verliert mit der Zeit an Licht ... ";

	public string live2 = "... dieses Licht stellt dein Leben dar";

	public string live3 = "... lasse es nicht erlischen!\nSammle dazu die schwebenden Lichter ein";

	public string shadows = "Pass gut auf die Schatten auf!\n Sie entziehen dir Licht !";

	public string tip = "Siehe dich immer gut um und nutze deine Umgebung";

	public string collapse = "Was ist das? Was passiert?\n Es bricht alles zusammen ?!?!";

	public string fall = "Nein ... Neeeiinn ... Ich kann nicht ...\n mein Traum zerfällt !!";

	private Text text;

	public string [] messages;

	public float [] speaker;

	public int counter = 0;

	private int speakerCounter = 0;

	public bool scene1 = false;




	public float gretel = 1;

	public float haensel = 2;

	public float mom = 3;

	public float dad = 4;




	// Use this for initialization
	void Start () {

		text = GetComponent<Text> ();

		if (scene1 == true ) {

			messages = new string[10];

			speaker = new float[10];


			messages [0] = welcome;
			speaker [0] = gretel;

			messages [1] = move;
			speaker [1] = haensel;

			messages [2] = where;
			speaker [2] = gretel;

			messages [3] = live;
			speaker [3] = haensel;

			messages [4] = live2;
			speaker [4] = gretel;

			messages [5] = live3;

			messages [6] = shadows;

			messages [7] = tip;

			messages [8] = collapse;

		}

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
}
