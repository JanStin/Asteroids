using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;
    [SerializeField] private Vector3 spawnValues;
    public int maxCountSpawnObject = 5;
    public float timeBetweenWaves = 4;

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
            int countSpawnObject = random.Next(1, maxCountSpawnObject + 1);
            
            for (int i = 0; i < countSpawnObject; i++)
            {
                Vector3 spawnPosition = new Vector3(
                    Random.Range(-spawnValues.x, spawnValues.x),
                    spawnValues.y,
                    spawnValues.z
                );

                Instantiate(spawnObject, spawnPosition, Quaternion.identity);

                yield return new WaitForSeconds(Random.Range(0.3f, 1.2f));
            }

            yield return new WaitForSeconds(timeBetweenWaves);
        }        
    }
}
