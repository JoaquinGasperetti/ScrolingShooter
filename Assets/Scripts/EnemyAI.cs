using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 5f;
    private Transform player;

    void Start()
    {
        
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }
    }

    void Update()
    {
        if (player == null) return;

        
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        
        transform.LookAt(player);
    }
}
