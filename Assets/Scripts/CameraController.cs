using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    //public GameObject target;
    public float speed = 20;
    public bool orbitY = false;

    // Use this for initialization
    void Start()
    {
        //offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        //transform.position = player.transform.position + offset;
        if (player != null)
        {
            transform.LookAt(player.transform);
            if (Input.GetKey(KeyCode.A))
            {
                if (orbitY)
                {
                    transform.RotateAround(player.transform.position, Vector3.up, Time.deltaTime * 30);
                }
            }

            if (Input.GetKey(KeyCode.D))
            {
                if (orbitY)
                {
                    transform.RotateAround(player.transform.position, Vector3.right, Time.deltaTime * 30);
                }
            }
        }
    }

}
