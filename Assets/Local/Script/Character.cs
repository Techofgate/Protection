using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	Rigidbody2D Body;
	public Sprite[] anime;
	int TextureCnt = 0;
	float animationDelayTime=0;
	float animationDelay = 2f / 60f;
	public float speed;
	public bool isMove = true;
	bool isAnimate = true;
	public bool isDeath = false;
	public GameObject DeathParticle;
	public GameObject database;
    // Start is called before the first frame update
    void Start()
    {
		Body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		if (isDeath)
			return;
		if (isAnimate)
		{
			animationDelayTime += Time.deltaTime;
			if (animationDelayTime >= animationDelay)
			{
				animationDelayTime = 0;
				NextTexture();
			}
		}
		if (isMove)
			move();

	}
	public void move()
	{
		transform.position += Time.deltaTime * speed * new Vector3(1f, 0f,0f);
	}
	void NextTexture()
	{
		TextureCnt++;
		if (TextureCnt >= anime.Length)
			TextureCnt = 0;
		gameObject.GetComponent<SpriteRenderer>().sprite = anime[TextureCnt];
	}
	public void Death()
	{
		isDeath = true;
		var temp = Instantiate(DeathParticle, gameObject.transform);
		temp.GetComponent<ParticleSystem>().Play();
		temp.transform.parent = null;
		temp.transform.localScale = new Vector3(1f, 1f, 1f);
		database.GetComponent<DataBase>().Time--;
		Destroy(gameObject);
	}
}
