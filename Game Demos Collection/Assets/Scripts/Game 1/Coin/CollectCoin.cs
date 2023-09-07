using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
	public AudioSource coin;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        coin.Play();
		CollectibleControl.coinCount += 1;
		this.gameObject.SetActive(false);
    }

}
