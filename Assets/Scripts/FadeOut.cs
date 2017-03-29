using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FadeOut : MonoBehaviour {

	public void OnPointerClick () {
		StartCoroutine("ChangeLevel");
	}

	IEnumerator ChangeLevel () {
		float fadeTime = GameObject.Find ("GM").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene ("The World Outside Our Own 1");
	}

}
