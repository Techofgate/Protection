using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
	public GameObject crossHair;
	public GameObject muzzle;
	public Vector3 mousePos;
	public GameObject DataBase;
	public GameObject GunFire;
	bool mousedown = false;
    // Start is called before the first frame update
    void Start()
    {
		Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
		transform.LookAt(crossHair.transform.position);
		if (Input.GetMouseButtonDown(0)==true)
		{
			mousedown = true;
			GunFire.GetComponent<AudioSource>().Play();
		}
		if (Input.GetMouseButtonUp(0) == true)
		{
			mousedown = false;
			stopFlash();
		}
		if (mousedown == true)
		{
			if (muzzle.GetComponent<ParticleSystem>().isPlaying == false)
			{
				muzzle.GetComponent<ParticleSystem>().Play();
			}
			mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0f, 0f, 10f));
			mousePos.z = crossHair.transform.position.z-2;
			RaycastHit2D[] hits = Physics2D.RaycastAll(mousePos, Vector3.forward);
			foreach (var i in hits)
			{
				if (i.collider.GetComponent<Character>())
				{
					i.collider.gameObject.GetComponent<Character>().Death();
				}
				if (i.collider.GetComponent<Enemy>())
				{
					i.collider.gameObject.GetComponent<Enemy>().HP -= 5;
				}
			}
		}
    }
	void stopFlash()
	{
		muzzle.GetComponent<ParticleSystem>().Stop();
	}
}
