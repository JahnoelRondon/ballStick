using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    Level level;

    void Start()
    {
        level = FindObjectOfType<Level>();
        level.countBreakables();
    }

    private void OnCollisionEnter(Collision other)
    {
        switch (other.collider.gameObject.tag)
        {
            case "Ball":
                level.reduceBreakableNumber();
                Destroy(this.gameObject);
                break;
        }
    }

}
