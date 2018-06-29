using UnityEngine;
using System.Collections;
 
public class FadeInAndOut : MonoBehaviour
{
	public Texture2D fadeOutTexture;
	public float fadeSpeed = 0.8f;
 
	private int drawDepth = -1000;
	private float alpha = 1.0f;
	private int fadeDir = -1;

	private void OnEnable()
	{
		alpha = 0;
		BeginFade(1);
	}

	void OnGUI ()
	{
		alpha += fadeDir * fadeSpeed * Time.deltaTime;
 
		alpha = Mathf.Clamp01 (alpha);
 
		GUI.color = new Color (GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawDepth;
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), fadeOutTexture);

		if (alpha >= 1)
			fadeDir = -1;
	}
 
	public float BeginFade (int direction)
	{
		fadeDir = direction;
		return(fadeSpeed);
	}
 
}