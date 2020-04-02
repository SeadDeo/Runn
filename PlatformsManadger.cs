using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsManadger : MonoBehaviour
{
    public GameObject platform;
    public int platformsAmount;//кол-во платформ в списке
    List<GameObject> platforms;//сам список
    void Start()
    {
        platforms=new List<GameObject>();

        for(int i=0;i<platformsAmount;i++)
        {
            GameObject obj = (GameObject) Instantiate (platform);
            obj.SetActive(false);
            platforms.Add(obj);
        }
    }

    // Update is called once per frame
   public GameObject GetPlatform()
   {
       for(int i=0;i<platforms.Count;i++)
       {
           if(!platforms[i].activeInHierarchy)
           {
               return platforms[i];
           }
       }
       GameObject obj = (GameObject) Instantiate (platform);
        obj.SetActive(false);
        platforms.Add(obj);
        return obj;
   }
}
