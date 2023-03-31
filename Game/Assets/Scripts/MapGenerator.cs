
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject tile;
    public Sprite groundSprite;
    public Sprite waterSprite;
    public Sprite grassSprite;
    void Start()
    {
        for (int i = 0; i < 200; i++)
        {
            for (int j = 0; j < 200; j++)
            {
                float perlinValue = Mathf.PerlinNoise((i * 0.1f)*3f, (j* 0.1f))*5f;
                var newTile = Instantiate(tile);
                newTile.transform.position = new Vector3(j, i, 0);
                

                if (perlinValue < 2f)
                {
                    newTile.GetComponent<SpriteRenderer>().sprite = groundSprite;
                    newTile.GetComponent<SpriteRenderer>().sprite = grassSprite;
                }
                
               
                
                if (perlinValue >= 2.5f)
                {
                    newTile.GetComponent<SpriteRenderer>().sprite = waterSprite;
                }
            }
            
        }
    }

    
}
