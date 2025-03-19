using UnityEngine;

public class ObstacleSpawner: MonoBehaviour
{
    public Transform player;
    public Transform obstacleParent; // Parent object containing all obstacles
    public float respawnDistance = 50f; // When to move obstacles forward
    public float moveDistance = 100f;   // How far they move forward

    void Update()
    {
        foreach (Transform obstacle in obstacleParent)
        {
            if (player.position.z > obstacle.position.z + respawnDistance)
            {
                MoveObstacleForward(obstacle);
            }
        }
    }

    void MoveObstacleForward(Transform obstacle)
    {
        obstacle.position += new Vector3(0, 0, moveDistance);
    }
}