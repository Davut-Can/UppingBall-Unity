using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public float hiz;
    public bool a=true;
    void Start()
    {

    }

    void Update()
    {
        if (a==true)
        {
            hiz += 1 * Time.deltaTime;
            transform.localScale = new Vector3(hiz, hiz);
        }

        if (transform.localScale.y >= 2)
        {
            a = false;
        }

        if (a == false)
        {
            hiz -= 1 * Time.deltaTime;
            transform.localScale = new Vector3(hiz, hiz);
        }

        if(transform.localScale.y<= -2)
        {
            a = true;
        }






        }
}
