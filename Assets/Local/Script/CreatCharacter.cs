using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatCharacter : MonoBehaviour
{
	public GameObject character;
	public GameObject Enemy;
	public GameObject database;
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine("creatCharacter");
		StartCoroutine("creatEnemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	IEnumerator creatCharacter()
	{
		while (true)
		{
			/*int temp = 0;
			temp = (int)Random.Range(0f, 2f);

			if (temp==2)
			{
				var ins = Instantiate(character, gameObject.transform);
				ins.transform.localPosition = new Vector3(-9f, -0.2f, 0f);
				ins.GetComponent<Character>().database = database;
			}
			*/
			
			{
				var ins = Instantiate(character, gameObject.transform);
				ins.transform.localPosition = new Vector3(9f, -0.2f, 0f);
				ins.GetComponent<Character>().speed = -ins.GetComponent<Character>().speed;
				ins.GetComponent<SpriteRenderer>().flipX=true;
				ins.GetComponent<Character>().database = database;

			}
			yield return new  WaitForSeconds(1.5f);
		}
	}
	IEnumerator creatEnemy()
	{
		while (true)
		{
			float temp = 0;
			temp = Random.Range(-8f, 12f);
			if (temp > 8)
			{
				temp -= 4;
			}
			var ins = Instantiate(Enemy, transform);
			ins.transform.localPosition = new Vector3(temp, 4f, 0f);
			ins.GetComponent<Enemy>().database = database;
			yield return new WaitForSeconds(3f);
		}
	}
}
