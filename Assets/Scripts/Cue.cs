using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
public class Cue : MonoBehaviour {

    public Rigidbody cue;
    public float speed;

    void Update()
    {
        Invoke("HitBall", 1f);
        ActivateCue();

    }

    private void HitBall()
    {
        cue.AddForce(new Vector3(0f, 0f, speed), ForceMode.Impulse);
        cue.gameObject.SetActive(false);
    }

    private void ActivateCue()
    {
        if (speed < 1)
        {
            cue.gameObject.SetActive(true);
        }
    }
}
