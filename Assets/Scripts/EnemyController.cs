using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5f;
    public int point = 1;
    public ScoreManager manager;
    public TimeManager timeManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
        if(timeManager.remainTime<=0f) Destroy(gameObject);
    }



    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
