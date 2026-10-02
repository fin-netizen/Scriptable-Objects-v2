using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public float displayValue;
    public PlayerSO playerData;

    void Start()
    {
        playerData.Health = 5;
    }


    public void DisplayHealth()
    {
        displayValue = playerData.Health;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        
    }
}
