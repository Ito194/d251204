using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float limitTime = 60;
    public float remainTime;
    bool isDisplay = false;
    public string gameoverSceneName = "GameOver";

    private void Awake()
    {
        remainTime = limitTime;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (remainTime > 0)
        {
            remainTime -= Time.deltaTime;
        }
        else
        {
            remainTime = 0;
            if (!isDisplay)
            {
                SceneManager.LoadSceneAsync(gameoverSceneName, LoadSceneMode.Additive);
                isDisplay = true;
            }
        }

    }
}
