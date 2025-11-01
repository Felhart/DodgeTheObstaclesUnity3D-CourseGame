using System.Xml.Serialization;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 1.0f;
    Vector3 playerPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {

        playerPosition = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        moveToPlayer();
        DestroyWhenReached();
    }
    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void moveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
}
