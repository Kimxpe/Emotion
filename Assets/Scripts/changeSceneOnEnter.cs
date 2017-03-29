using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeSceneOnEnter : MonoBehaviour {

	void Start () {
	}
	

	void OnTriggerEnter (Collider col) {

		SceneManager.LoadScene ("The World Outside Our Own 4");
	}
}
