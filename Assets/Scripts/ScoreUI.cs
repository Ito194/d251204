using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public ScoreManager manager;
    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + manager.point;
        Debug.Log(manager.point);
    }
}
