using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int point=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void AddPoint(int point)
    {
        this.point += point;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
