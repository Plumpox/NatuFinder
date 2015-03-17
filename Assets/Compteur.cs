using UnityEngine;
using System.Collections;

public class Compteur : MonoBehaviour {

	private int compteur = 0;
	private bool voiceOnce = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (compteur == 1 && !voiceOnce) {
			audio.Play (); 
			voiceOnce = true;
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "natu") {
			compteur++; // compteur = compteur + 1; compteur += 1;
			other.GetComponentInChildren<Collider>().enabled = false;
			}
		if (other.name == "xatu" && compteur == 3) {
			Debug.Log ("xatu"); 
			Application.LoadLevel ("Phase1");
		}
	}
}
