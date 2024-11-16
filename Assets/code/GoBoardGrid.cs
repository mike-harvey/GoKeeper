using UnityEngine;

public class GoBoardGrid : MonoBehaviour
{
    public GameObject lineObjectX;
    public GameObject lineObjectY;
    public GameObject hoshiObject;
    public float gridDimensionX = 0.394f;
    public float gridDimensionY = 0.424f;
    public int numberofLinesX = 19;
    public int numberofLinesY = 19;

    void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        float spacingX = gridDimensionX / (numberofLinesX - 1);
        float spacingY = gridDimensionY / (numberofLinesY - 1);

        float halfSizeX = gridDimensionX / 2f;
        float halfSizeY = gridDimensionY / 2f;

        Debug.Log($"spacingX = {spacingX}");
        Debug.Log($"spacingY = {spacingY}");
        Debug.Log($"halfSizeX = {halfSizeX}");
        Debug.Log($"halfSizeY = {halfSizeY}");

        for (int i = 0; i < 19; i++)
        //for (int i = 0; i < numberofLinesX; i++)
        {
            GameObject line = Instantiate(lineObjectY, transform);
            line.transform.localPosition = new Vector3(0, 0.0291f, -halfSizeX + i * spacingX);
            //line.transform.localPosition = new Vector3(-halfSizeX - i * spacingX, 0.291f, 0f);
            //line.transform.localScale = new Vector3(gridDimensionY, 0.007f, 0.002f);
            Debug.Log($"MJH: position: {line.transform.localPosition}");
        }

        for (int i = 0; i < 19; i++)
        //for (int i = 0; i < numberofLinesY; i++)
        {
            GameObject line = Instantiate(lineObjectX, transform);
            line.transform.localPosition = new Vector3(-halfSizeY + i * spacingY, 0.0291f, 0);
            //line.transform.localScale = Vector3.one;
            //line.transform.Rotate(0, 90, 0);
            Debug.Log($"MJH: position: {line.transform.localPosition}");
        }

        for (int i = -1; i < 2; i++)
        {
            for (int j = -1; j < 2 ; j++)
            {
                GameObject hoshi = Instantiate(hoshiObject, transform);
                hoshi.transform.localPosition = new Vector3(i * 6f * spacingY, 0.0291f, j * 6f * spacingX);
            }
        }
    }
}
