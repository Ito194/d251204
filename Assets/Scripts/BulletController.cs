using UnityEngine;

public class BulletController : MonoBehaviour
{
    public string enemyTag = "Enemy";
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(enemyTag))
        {
            var e=collision.gameObject.GetComponent<EnemyController>();
            if (e != null)
            {
                e.manager?.AddPoint(e.point);
            }

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
