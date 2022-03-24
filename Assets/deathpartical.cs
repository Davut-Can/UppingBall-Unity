using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathpartical : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
         if(GameObject.Find("Main Camera").GetComponent<camerafollow>().died == true)
        {
            this.transform.parent = null;
        }      
    }
}
