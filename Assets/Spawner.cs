using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] float timeBetweenSpawns;
    float spawnElapsed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnElapsed += Time.deltaTime;

        if(spawnElapsed >= timeBetweenSpawns)
        {
            Spawn();
            spawnElapsed = 0;
        }
    }

    private void Spawn()
    {
        GameObject g = Instantiate(playerPrefab, transform);
        float x = Random.Range(0, GetComponent<RectTransform>().rect.width);
        float y = Random.Range(0, GetComponent<RectTransform>().rect.height);

        g.transform.position = new Vector2(x, y);
        Destroy(g.gameObject, 2f);
    }
}
