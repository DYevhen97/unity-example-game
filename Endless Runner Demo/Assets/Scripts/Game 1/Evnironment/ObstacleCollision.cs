using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
	public GameObject thePlayer;
	public GameObject charModel;
	public AudioSource crash;
	public GameObject mainCam;
	public GameObject levelControl;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
		thePlayer.GetComponent<PlayerMovement>().enabled = false;
		charModel.GetComponent<Animator>().Play("Stumble");
		levelControl.GetComponent<LevelDistance>().enabled = false;
		crash.Play();
		mainCam.GetComponent<Animator>().enabled = true;
		levelControl.GetComponent<EndRunSequence>().enabled = true;
    }

}
