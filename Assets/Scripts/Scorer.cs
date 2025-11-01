using UnityEngine;

public class Scorer : MonoBehaviour
{
    int bumpedCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit")
        {
            bumpedCount++;
            Debug.Log("you bumped something this many times: " + bumpedCount);
        }

    }
}
