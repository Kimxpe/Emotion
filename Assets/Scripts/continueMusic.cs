using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continueMusic : MonoBehaviour {

		private AudioSource _audioSource;
		private void Awake()
		{
			DontDestroyOnLoad(transform.gameObject);
			_audioSource = GetComponent<AudioSource>();
		}

		public void PlayMusic()
		{
			if (_audioSource.isPlaying) return;
			_audioSource.Play();
		}

		public void StopMusic()
		{
		//if (SceneManager.LoadScene ("The World Outside Our Own 4")) {
			_audioSource.Stop ();
		//}
		}
}
