using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public GameObject coinPrefab;  // Assign your ring asset here
    public Transform ground;       // Assign the ground GameObject
    public int maxCoins = 5;       // Number of coins to spawn
    public float groundWidth = 10f; // Adjust based on ground size
    public float groundLength = 50f; // Adjust based on ground size
    public Text coinText;           // UI Text to show coins collected
    private int coinCount = 0;       // Player's coin count

    void Start()
    {
        SpawnCoins();  
        UpdateCoinUI();
    }

    void SpawnCoins()
    {
        for (int i = 0; i < maxCoins; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(ground.position.x - groundWidth / 2, ground.position.x + groundWidth / 2),
                1f, // Height to ensure visibility
                Random.Range(ground.position.z, ground.position.z + groundLength / 2) // Avoid extreme Z values
            );

            Instantiate(coinPrefab, randomPosition, Quaternion.identity, ground); // Parent it to ground
        }
    }

    void UpdateCoinUI()
    {
        coinText.text = "Coins: " + coinCount;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            UpdateCoinUI();
            Destroy(other.gameObject);
        }
    }
}
