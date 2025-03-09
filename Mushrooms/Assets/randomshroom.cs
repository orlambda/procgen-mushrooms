using UnityEngine;

// Mushrooms are made of a top and bottom cylinder.

// This script randomises the width of a cylinder by adding to its scale.

// The script does not consider where in the mushroom the cylinder is
// or the starting width of the cylinder.

public class randomshroom : MonoBehaviour
{
    public float minWidth = 0.1f;
    public float maxWidth = 1.1f;
    private float width;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        width = Random.Range(minWidth, maxWidth);
        Vector3 widthIncrement = new Vector3(width, 0, width);
        gameObject.transform.localScale += widthIncrement;
    }
}
