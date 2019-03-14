using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class EndUI : MonoBehaviour
{
	public GameObject database;
	public TextMeshProUGUI Text;
	public GameObject EndBgm;
    // Start is called before the first frame update
    void Start()
    {
		Cursor.visible = true;
		Time.timeScale = 1;
		database = GameObject.FindGameObjectWithTag("DataBase");
		Text.text = ""+database.GetComponent<DataBase>().Score;
		EndBgm.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void restart()
	{
		SceneManager.LoadScene("Main");	
	}
	public void title()
	{
		SceneManager.LoadScene("Start");
	}
	public void exit()
	{
		Application.Quit();
	}
}
