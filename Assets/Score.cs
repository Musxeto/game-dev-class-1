using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;  
    public Text scoreText;    
    private float startZ;     

    void Start()
    {
        startZ = player.position.z;  
    }

    void Update()
    {
        float distance = player.position.z - startZ;  
        int score = Mathf.FloorToInt(distance);  
        scoreText.text = score.ToString();  // Fixed capitalization issue
    }
}
