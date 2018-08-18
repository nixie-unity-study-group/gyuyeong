using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float enemySpeed = 0.1f;
    public float enemyBorderY = -6;
    public float fireInterval = 0.1f;
    public GameObject bullet;

    private Vector2 currentPosition;
    private Vector2 nextPosition;
    private float _nextFire;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > enemyBorderY)
        {
            Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
            Vector2 nextPosition = new Vector2(transform.position.x, enemyBorderY);
            transform.position = Vector2.MoveTowards(currentPosition, nextPosition, 0.1f);
        } else {
            Object.Destroy(this.gameObject);
        }
        if (Time.time > _nextFire) {
            _nextFire = Time.time + fireInterval;
            Instantiate(bullet, new Vector2(transform.position.x, transform.position.y - 1), Quaternion.identity);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerBullet") {
            GameManager.AddScore(5);
            Object.Destroy(this.gameObject);
        }
    }
}
