using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public ParticleSystem death_partical;
    public SpriteRenderer Player;
    public camerafollow camfollowing;

    void Start()
    {
        death_partical = GameObject.Find("DeathPartical").GetComponent<ParticleSystem>();
        camfollowing = GameObject.Find("Main Camera").GetComponent<camerafollow>();



        death_partical.loop = false;
        death_partical.Pause();

    }
    /*
     Karakterin �lmesi ��in oyuncunun Tagi Player Olmal�
    Ve BoxCollider2D Olmal�
    */ 
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            death_partical.Play();
            camfollowing.died = true;
            StartCoroutine(oldun(1));
            Debug.Log("de�din");

        }
    }

    IEnumerator oldun(float time)
    {
        yield return new WaitForSeconds(time);
        Application.LoadLevel(0);

    }
}



