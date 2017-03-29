using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour {

	public Texture2D fadeOutTexture;	//the texture that wil overlay the screen.
	public float fadeSpeed = 0.0f;

	private int drawDepth = -1000;
	private float alpha = 1.0f;
	private int fadeDir = -1;

	void OnGUI () {
		//fade out/in the alpha value using a direction, a speed and Time.deltatime to convert the operation
		alpha += fadeDir * fadeSpeed * Time.deltaTime;
		//force (clamp) the number between 0 and 1 because GUI.color uses alpha values between 0 and 1
		alpha = Mathf.Clamp01(alpha);

		//set color of our GUI (in this case our texture). All color values remain the same and the alpha is set to the alpha variable.
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawDepth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);

	}
	//sets fadeDir to the direction parameter making the scene fade in if -1 and out if 1
	public float BeginFade (int direction) {
		fadeDir = direction;
		return (fadeSpeed); // return the fadeSpeed variable so it's easy to time the Application.LoadLevel

	}

	//OnLevelWasLoaded is called when scene is loaded. 
	void OnLevelWasLoaded () {
		BeginFade(-1);

	}
}
