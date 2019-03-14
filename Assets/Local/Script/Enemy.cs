using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public GameObject database;
	public float HP = 100;
	public GameObject DeathParticle;
	public GameObject DeathAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }
	private void Update()
	{
		if (HP <= 0)
		{
			Death();
		}
	}
	// Update is called once per frame
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.GetComponent<Character>())
		{
			collision.gameObject.GetComponent<Character>().Death();
		}
	}
	public void Death()
	{
		var temp = Instantiate(DeathParticle, gameObject.transform);
		temp.GetComponent<ParticleSystem>().Play();
		temp.transform.parent = null;
		temp.transform.localScale = new Vector3(1f, 1f, 1f);
		database.GetComponent<DataBase>().Score += 100;
		var aud=Instantiate(DeathAudio, transform);
		aud.transform.parent = null;
		aud.GetComponent<AudioSource>().Play();
		Destroy(gameObject);
	}
}
