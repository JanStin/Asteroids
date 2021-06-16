using UnityEngine;

public class Laser : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 0.1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        GameAsteroidManager.ChangeScore();
    }
}
