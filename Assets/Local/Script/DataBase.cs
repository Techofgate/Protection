using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataBase : MonoBehaviour
{
	public static int initT = 60;
	public static int initS = 0;
	public static int Time;
	public static int Score;
	bool isEnd = false;
	private void Start()
	{
		Init();
		DontDestroyOnLoad(gameObject);
	}
	private void Update()
	{
		if (Time <= 0&&!isEnd)
		{
			EndofGame();
		}
	}
	public static void Init()
	{
		Time = initT;
		Score = initS;
	}
	void EndofGame()
	{
		isEnd = true;
		SceneManager.LoadScene("End");
		
	}
}
