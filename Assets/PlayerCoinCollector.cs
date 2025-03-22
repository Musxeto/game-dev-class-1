using UnityEngine;
using UnityEngine.UI;
public class PlayerCoinCollector : MonoBehaviour
{
    public Text coinText;  // UI text for displaying coins
    private int coinCount = 0;  

    void UpdateCoinUI()
    {
        coinText.text = "Coins: " + coinCount.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) // Ensure the tag matches exactly
        {
            coinCount++;
            UpdateCoinUI();
            Destroy(other.gameObject);
        }
    }
}
