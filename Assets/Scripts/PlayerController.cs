using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {


    private Rigidbody rb;
    public float speed;
    private int count;
    public Text countText, winText;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0, 0, moveVertical);

        Invoke("HitBall", 1f);
    }

    private void HitBall()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Camera.main.transform.forward * speed);
        }
    }
}
