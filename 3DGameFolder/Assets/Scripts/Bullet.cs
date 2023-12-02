using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Transform hitTransform = collision.transform;
        if (hitTransform.gameObject.CompareTag("Target"))
        {
            print("hit " + hitTransform.gameObject.name + " !");
            Destroy(gameObject);
            hitTransform.GetComponent<EnemyHealth>().TakeDamage(1);
        }

        if (hitTransform.gameObject.CompareTag("Terrain"))
        {
            //print("hit a terrain !");
            Destroy(gameObject);
        }
    }

}
