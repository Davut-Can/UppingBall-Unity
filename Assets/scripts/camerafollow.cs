using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player;
   [SerializeField] public bool died;

    void Start()
    {
        //offset = transform.position - target.position;
        


    }

    void Update()
    {
        if (died == false)
        {
            if (player.position.y > transform.position.y)
            {
                transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
            }
        }
        // transform.position = target.position + offset;
        // backset=Vector2.Lerp(transform.position, target.position, hiz * Time.deltaTime);
        // transform.position =Vector2.Lerp(transform.position, target.transform.position, hiz * Time.deltaTime);
        // transform.position = Vector3.Lerp(offset,target.transform.position,hiz);

     

    }
}
