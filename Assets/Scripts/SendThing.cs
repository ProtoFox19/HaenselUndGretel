using UnityEngine;
using System.Collections;

public class SendThing : MonoBehaviour
{

    public GameObject thing;

    void start()
    {

    }
    private void OnMouseDown()
    {
        if (thing.name.Equals("murmeln"))
        {

            GameObject.FindGameObjectWithTag("Pieces").GetComponent<HasReachedKomode>().onClickMurmeln();
        }
        if (thing.name.Equals("Kiesel"))
        {
            GameObject.FindGameObjectWithTag("Pieces").GetComponent<HasReachedKomode>().onClickSteine();
        }
        if (thing.name.Equals("brot"))
        {
            GameObject.FindGameObjectWithTag("Pieces").GetComponent<HasReachedKomode>().onClickBrot();
        }
    }
}
