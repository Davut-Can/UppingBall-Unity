using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jump : MonoBehaviour
{
    public Rigidbody2D player;
    public float balljump;
    public int skor;
    public Text puan;
    public camerafollow cam;
    void Start()
    {
        puan = GameObject.Find("Points").GetComponent<Text>();
        player = GetComponent<Rigidbody2D>();
        player.isKinematic = true;
    }

    void Update()
    {
        puan.text = "" + skor;
        if (cam.died == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                player.velocity = Vector2.up * balljump;
                player.isKinematic = false;
            }
            else
            {
                player.AddForce(Vector2.zero);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                this.gameObject.tag = "Untagged";
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                this.gameObject.tag = "Player";
            }
        }
        else
        {
            player.simulated = true;
            GameObject.Find("Player").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("Player").GetComponent<jump>().enabled = false;

        }
    }
}
