using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowKnife : MonoBehaviour {

    public GameObject knifeprefab;
    public Transform knifeSpawn;
    public float fireTime = 1.2f;
    private bool isFiring = false;
    void SetFiring()
    {
        isFiring = false;
    }
    void Fire()
    {
        isFiring = true;
        Instantiate(knifeprefab, knifeSpawn.position, knifeSpawn.rotation);
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
        Invoke("SetFiring", fireTime);
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (!isFiring)
            {
                Fire();
            }
        }
    }


}
