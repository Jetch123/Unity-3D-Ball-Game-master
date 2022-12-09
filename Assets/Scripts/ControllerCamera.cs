using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCamera : MonoBehaviour
{
	public GameObject player; //player represents the Player who is the ball
    private Vector3 offset; 
    void Start () {
         offset = transform.position - player.transform.position;
 //we start by recovering the initial distance between the Camera and the Player
    }
    void LateUpdate () {
         transform.position = player.transform.position + offset;
 //The Camera will always keep the same distance from the Player
    }


}
