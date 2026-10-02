using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public PlayerSO playerData;

    public TextMeshProUGUI health;
    public TextMeshProUGUI score;
    public TextMeshProUGUI lives;

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
        //output playerdata.health

        health.text = "the players health is " + playerData.Health;
        score.text = "the players score is " + playerData.Score;
        lives.text = "your life count is " + playerData.Lives;
        if (Keyboard.current.periodKey.wasPressedThisFrame)
        {
            playerData.Score++;
        }
        if (Keyboard.current.commaKey.wasPressedThisFrame)
        {
            playerData.Score--;
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene("SecondScene");
        }
    }
}
