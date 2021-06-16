using System.Collections;
using UnityEngine;

public class AsteroidsSpawn : MonoBehaviour
{
    [SerializeField] private GameObject asteroid;
    [SerializeField] private Vector3 spawnValues;
    public float speed = 2.0f;

    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    private IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(1);
        
        System.Random random = new System.Random();
        
        while (true)
        {
            int countAsteroids = random.Next(1, 6);
            
            for (int i = 0; i < countAsteroids; i++)
            {
                Vector3 spawnPosition = new Vector3(
                    Random.Range(-spawnValues.x, spawnValues.x),
                    spawnValues.y,
                    spawnValues.z
                );

                Instantiate(asteroid, spawnPosition, Quaternion.identity);
                //Rigidbody asteroidRigidbody = tempAsteroid.GetComponent<Rigidbody>();
                //asteroidRigidbody.velocity = speed * new Vector3(0, -1, 0);

                yield return new WaitForSeconds(Random.Range(0.3f, 1.2f));
            }

            yield return new WaitForSeconds(4);
        }        
    }
}
