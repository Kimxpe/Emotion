using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterToGameExit : MonoBehaviour {

	void Start () {
	}


	void OnTriggerEnter (Collider col) {

		SceneManager.LoadScene ("The World Outside Our Own 2");
	}
}
