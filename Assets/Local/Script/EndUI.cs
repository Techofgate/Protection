using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class EndUI : MonoBehaviour
{
	public TextMeshProUGUI Text;
	AudioSource EndBgm;
    void Start()
    {
		Cursor.visible = true;
		Time.timeScale = 1;
		Text.text = ""+DataBase.Score;
		EndBgm = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio>().EndBgm.GetComponent<AudioSource>();
		EndBgm.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void restart()
	{
		DataBase.Init();
		SceneManager.LoadScene("Main");	
	}
	public void title()
	{
		DataBase.Init();
		SceneManager.LoadScene("Start");
	}
	public void exit()
	{
		Application.Quit();
	}
}
