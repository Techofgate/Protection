using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataBase : MonoBehaviour
{
	public int Time = 10;
	public int Score = 0;
	bool isEnd = false;
	private void Start()
	{
		DontDestroyOnLoad(gameObject);
	}
	private void Update()
	{
		if (Time <= 0&&!isEnd)
		{
			EndofGame();
		}
	}
	void EndofGame()
	{
			isEnd = true;
			SceneManager.LoadScene("End");
		
	}
}
