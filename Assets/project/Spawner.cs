using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject prefab;
    public bool isSpawned = false;
    public Transform spawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSpawned )
        {
            Instantiate(prefab);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
