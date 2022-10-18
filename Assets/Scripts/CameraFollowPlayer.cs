using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        // transform.postion means the position of the camera in world space
        // we are taking the cameras position and we are equaling it to the players position in world space on the x and y axis
    }
}
