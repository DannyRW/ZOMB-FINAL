using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife2D : MonoBehaviour {

    public float speed = 3.0f;
    public float destroyTime = 0.7f;
    void Start()
    {
        Invoke("Die", destroyTime);
    }
    void Die()
    {
        Destroy(gameObject);
    }
    void OnDestroy()
    {
        CancelInvoke("Die");
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }


}
