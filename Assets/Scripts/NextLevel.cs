using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public int sceneToLoad;
    PlayerController playerC;


    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {

            LoadLevel();
        }
    }




    void LoadLevel() {

        // SceneManager.LoadScene(sceneToLoad);
        

        if (PlayerPrefs.GetInt(sceneToLoad.ToString()) == 0) {
            PlayerPrefs.SetInt(sceneToLoad.ToString(), 1);
        }
        StartCoroutine(FadeOUT());
        
    }

    IEnumerator FadeOUT()
    {
      //  GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(2);

        PlayerPrefs.SetInt(sceneToLoad.ToString(), 1);
       // simulateButton.LoadSceneNum(sceneToLoad);
    }

}
