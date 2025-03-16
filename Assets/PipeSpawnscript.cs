using JetBrains.Annotations;
using System.Threading;
using UnityEngine;

public class PipeSpawnscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float hieghtoffset = 10;
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }
    void SpawnPipe()
    {
        float lowestpoint=transform.position.y - hieghtoffset;
        float highestpoint = transform.position.y + hieghtoffset;

        Instantiate(Pipe, new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }
}