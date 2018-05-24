using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeHit2D : MonoBehaviour {

    public int damage = 5;
    public string damageTag = "";
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(damageTag))
        {
            other.SendMessage("TakeDamage", damage);
        }
        Destroy(gameObject);
    }
}
