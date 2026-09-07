using UnityEngine;

public class CoinValue : MonoBehaviour
{
    [SerializeField] private int _ScoreWorth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public int GetScoreWorth()
    {
        return _ScoreWorth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
