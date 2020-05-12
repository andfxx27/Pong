using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Screen height is based on camera size (camera size * 2)
    [SerializeField] float screenHeightInUnits = 10f;
    
    // Both minPosition and maxPosition is based on experiment -> move the paddle and see its transform until you see fit
    [SerializeField] float minPositionInUnits = 2.05f;
    [SerializeField] float maxPositionInUnits = 7.95f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yPositionInUnits = Input.mousePosition.y / Screen.height * screenHeightInUnits;

        Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y);
        paddlePosition.y = Mathf.Clamp(yPositionInUnits, minPositionInUnits, maxPositionInUnits);

        transform.position = paddlePosition;
    }
}
