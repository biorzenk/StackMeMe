using UnityEngine;

public class Spawn_Player : MonoBehaviour
{
    public static Spawn_Player Instance;

    [SerializeField] GameObject prefab_Player;
    public Transform point_Spawn;
    [SerializeField] CameraFollow cam;

    GameObject currentPlayer;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void SpawnPlayer()
    {
        if (point_Spawn != null)
        {
            Debug.LogError("point chua gan trong Inspector ");
            return;
        }

        if (currentPlayer != null)
        {
            Destroy(currentPlayer);
        }

        currentPlayer = Instantiate(
            prefab_Player,
            point_Spawn.position,
            Quaternion.identity
        );

        if (cam != null)
        {
            cam.SetTarget(currentPlayer.transform);
        }
    }
}
