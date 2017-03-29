using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeSceneOnTimer : MonoBehaviour {

 //public float timer = 10;

	void Start () {
	}
	

	void OnTriggerEnter (Collider col) {
		//timer -= Time.deltaTime;

		//if (timer <= 0) {
		SceneManager.LoadScene ("The World Outside Our Own 3");
		//}
		//Debug.Log("Scene should have changed!");
	}
}
