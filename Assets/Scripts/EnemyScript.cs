using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public PlayerSO playerData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerData.Health = 5;
        playerData.Score = 0;
        playerData.Lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
