using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float speed=3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized*speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab,firePoint.position,Quaternion.identity);
        }
    }
}
