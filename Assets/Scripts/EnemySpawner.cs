using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public ScoreManager ScoreManager;
    public TimeManager TimeManager;
    public GameObject enemyPrefab;
    public float interval = 1f;

    float left, right, top, bottom;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnRoutine());

        float height = 2f * Camera.main.orthographicSize;
        float width = height * Camera.main.aspect;

        left = Camera.main.transform.position.x - width / 2f;
        right = Camera.main.transform.position.x + width / 2f;
        bottom = Camera.main.transform.position.y - height / 2f;
        top = Camera.main.transform.position.y + height / 2f;

    }

    IEnumerator SpawnRoutine()
    {
        while (TimeManager.remainTime > 0)
        {
            var obj = Instantiate(enemyPrefab, new Vector3(Random.Range(left, right), top, 0), Quaternion.identity);
            var e = obj.GetComponent<EnemyController>();
            if (e != null)
            {
                e.manager = ScoreManager;
                e.timeManager = TimeManager;
            }
            yield return new WaitForSeconds(interval);
        }

    }

    // Update is called once per frame
    void Update()
    {
    }
}
