using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Objects;
    public Camera Cam;
    public float height=5;

    public int rastgele,obje_olusma_yuksekligi;
    void Start()
    {
        
    }

    void Update()
    {
        if (Cam.transform.position.y < height)
        {
            rastgele=Random.Range(0,Objects.Length);
            Debug.Log(rastgele);
           // height += 10*Time.deltaTime;
         //   transform.position = new Vector3(0,height,0);

           


        }

        if (Cam.transform.position.y > transform.position.y)
        {
            height += 10;
            transform.position = new Vector3(0, height, 0);
            if (rastgele == 3)
            {
                GameObject spawnlar = Instantiate(Objects[rastgele]);
                spawnlar.transform.position = new Vector3(transform.position.x-1.60f, transform.position.y + obje_olusma_yuksekligi*1.5f, transform.position.z);
                Destroy(spawnlar, 60);
                Debug.Log("Y Yüksekliði 1.5 katý ile çarpýldý:"+spawnlar.transform.position.y);
            }
            else
            {
                GameObject spawnlar = Instantiate(Objects[rastgele]);
                spawnlar.transform.position = new Vector3(transform.position.x, transform.position.y + obje_olusma_yuksekligi, transform.position.z);
                Destroy(spawnlar, 60);
            }
                
        }
    }
}
