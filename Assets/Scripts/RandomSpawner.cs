using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefab;      
    public int count = 30;
    public float rangeX = 18f;
    public float rangeZ = 18f;
    public float minY = 0.5f;      
    public bool randomScale = true;
    public Vector2 scaleRange = new Vector2(0.5f, 2f);

    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            Vector3 pos = new Vector3(
                Random.Range(-rangeX, rangeX),
                minY,
                Random.Range(-rangeZ, rangeZ)
            );

            GameObject go = Instantiate(prefab, pos, Quaternion.Euler(0, Random.Range(0, 360), 0));
            if (randomScale)
            {
                float s = Random.Range(scaleRange.x, scaleRange.y);
                go.transform.localScale = new Vector3(s, s, s);
            }
            go.name = "Obstacle_" + i.ToString("00");
            go.transform.parent = this.transform; 
        }
    }
}
