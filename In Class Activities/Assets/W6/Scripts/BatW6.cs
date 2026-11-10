using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";
    public float speed = 5f;
    private Transform playerTransform;
    private bool isChasing = false;

    private void Start() 
    {
        GameObject player = GameObject.FindGameObjectWithTag(playerTag);
        if (player != null) 
        {
            playerTransform = player.transform;
        }
    }
    private void update() 
    {
        if (isChasing && playerTransform !=null) 
        {
            MoveTowardsPlayer();
        }
    }
    private void MoveTowardsPlayer() 
    {
        float step = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, step);
    }
    public void StartChasing() 
    {
        isChasing = true;
    }
    public void StopChasing() 
    {
        isChasing = false;
    }
}
