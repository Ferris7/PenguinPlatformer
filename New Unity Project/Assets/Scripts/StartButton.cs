using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartButton : MonoBehaviour
{
	static public bool notShowing;

	public void Start()
	{
		Time.timeScale = 0;
		GameObject.FindGameObjectWithTag("PlayStart").SetActive(true);
	}

	public void Play()
    {
		Time.timeScale = 1;
		GameObject.FindGameObjectWithTag("PlayStart").SetActive(false);
		notShowing = true;
	}

}