using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class rocketScript : MonoBehaviour
{
    [Tooltip("In ms^-1")] [SerializeField] float Speed = 15f;
    [Tooltip("In m")] [SerializeField] float xRange = 4f;
    [Tooltip("In m")] [SerializeField] float yRange = 3.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        processTranslation();
    }

    void processTranslation()
    {
        float horizontalThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float verticalThrow = CrossPlatformInputManager.GetAxis("Vertical");

        float xOffset = horizontalThrow * Speed * Time.deltaTime;
        float yOffset = verticalThrow * Speed * Time.deltaTime;

        float rawXpos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawXpos, -xRange, xRange);

        float rawYpos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYpos, -yRange, yRange);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z);
    }
}
