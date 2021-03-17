using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
	static public GameObject GameOverMenu;
	static public GameObject Won;
	static public GameObject Lost;
	static public GameObject BG;

	void Start()
	{
		GameOverMenu = GameObject.FindGameObjectWithTag("GameOverMenu");
		Won = GameObject.FindGameObjectWithTag("Won");
		Lost = GameObject.FindGameObjectWithTag("Lost");
		BG = GameObject.FindGameObjectWithTag("BackGround");

		GameOverMenu.SetActive(false);
		Won.SetActive(false);
		Lost.SetActive(false);
		BG.SetActive(false);
	}

	public void Play()
	{
		Penguin.dead = false;
		GameManager.gameHasEnded = false;
		GameOverMenu.SetActive(false);
		Won.SetActive(false);
		Lost.SetActive(false);
		BG.SetActive(false);
		FindObjectOfType<GameManager>().Restart();
	}

}