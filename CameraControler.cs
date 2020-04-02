using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    PlayerConrtol player;
    Vector3 lastPosition;//позиция камеры
    float distanceToMove;//
    // Start is called before the first frame update
    void Start()
    {
        player= FindObjectOfType<PlayerConrtol>();
        lastPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToMove = player.transform.position.x - lastPosition.x;
        transform.position = new Vector3(transform.position.x+distanceToMove,transform.position.y,transform.position.z);
        lastPosition=player.transform.position;
    }
}
