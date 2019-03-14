using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
	public GameObject database;
	public TextMeshProUGUI text;
	float currentTime=0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		currentTime += Time.deltaTime;
		if (currentTime >= 1)
		{
			currentTime = 0;
			database.GetComponent<DataBase>().Time--;
		}
		text.text = ""+database.GetComponent<DataBase>().Time;
	}
}
