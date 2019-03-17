using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
	public GameObject GunFireAudio;
	public GameObject Vanish;
	public GameObject Bgm;
	public GameObject EndBgm;
	void Start()
	{
		DontDestroyOnLoad(gameObject);

	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
