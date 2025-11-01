using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xSpeed = 0f;
    [SerializeField] private float zSpeed = 0f;
    [SerializeField] private float ySpeed = 1f;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(xSpeed, ySpeed, zSpeed);
    }
}
