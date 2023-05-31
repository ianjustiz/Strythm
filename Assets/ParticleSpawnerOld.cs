using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawnerOld : MonoBehaviour
{
    [SerializeField] private GameObject particlePrefab;
    [SerializeField] private float particleInterval = 0.05f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnParticle(particleInterval, particlePrefab));
    }

    private IEnumerator spawnParticle(float interval, GameObject particle)
    {
        yield return new WaitForSeconds(interval);
        GameObject newParticle = Instantiate(particle, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnParticle(interval, particle));
    }
}
