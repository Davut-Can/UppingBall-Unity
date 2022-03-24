using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{
    public jump gidenskor;
    public int skor;
    private void Start()
    {
       gidenskor= GameObject.Find("Player").GetComponent<jump>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gidenskor.skor += skor;
            Destroy(gameObject);
        }
    }
}
