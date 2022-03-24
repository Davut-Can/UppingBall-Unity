using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliding : MonoBehaviour
{
    public Transform slidearea, slidearea2;
    public float slidespeed;
    public bool kontrol;
    void Start()
    {

    }

    void Update()
    {
        if (kontrol==true)
        { 
        transform.position = Vector3.Lerp(transform.position, slidearea.transform.position, slidespeed * Time.deltaTime);
        StartCoroutine(sayinebekle(2));
        }
        

    }

    IEnumerator sayinebekle(float time)
    {
       
            yield return new WaitForSeconds(time);

            kontrol = false;
            if (kontrol == false)
            {
                transform.position = Vector3.Lerp(transform.position, slidearea2.transform.position, slidespeed * Time.deltaTime);
               
                
                yield return new WaitForSeconds(time);
                kontrol = true;
            }

    }
}