using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<Renderer>().material.color = Color.black;
            gameObject.tag = "Hit";
        }
            
    }
}
