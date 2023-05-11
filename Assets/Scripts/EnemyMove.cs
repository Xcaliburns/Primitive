using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float speed = 10.0f;
    private GameObject player;

    void Start()
    {

        player = GameObject.Find("Player");
    }


    void Update()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        transform.position += (direction * speed * Time.deltaTime);
        // normalement ca ne sort pas mais soyons prudents .
        if (transform.position.y < -10 || transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("you collide an Enemy");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
        }
    }


}
