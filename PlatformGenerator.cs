using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
   public GameObject platform;
   public Transform generatorPoint;//точка когда надо делать новую платформу
   float platformWidth;//ширина BoxCollider у платформы
   public float distanceMin,distanceMax;// дистанция медлу платформами 
   //public float distanceMax;
   public float scaleMax,scaleMin;//размер между платформами 
   //public float scaleMin;
   public PlatformsManadger platformM;
    void Start()
    {
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
    }

    void Update()
    {
        if(transform.position.x<generatorPoint.position.x)
        {
            //scaleBetween = Random.Range(scaleMin,scaleMax);
            //distanceBetween = Random.Range(distanceMin,distanceMax);
            transform.localScale =new Vector3(Random.Range(scaleMin,scaleMax),platform.transform.localScale.y,transform.localScale.z);
            transform.position = new Vector3(transform.position.x+platformWidth+Random.Range(distanceMin,distanceMax),transform.position.y,transform.position.z);
            

            //Instantiate(platform,transform.position,transform.rotation);
           
           GameObject newPlatform = platformM.GetPlatform();
           newPlatform.transform.position = transform.position;
           newPlatform.transform.rotation = transform.rotation;
           newPlatform.transform.localScale = transform.localScale;
           newPlatform.SetActive(true);
        }
    }
}
