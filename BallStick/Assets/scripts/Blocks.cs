using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    [SerializeField] GameObject particleprefab;

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

                var prefab = Instantiate(particleprefab, transform.position, Quaternion.identity);
                Destroy(prefab, 1f);

                Destroy(this.gameObject);
                break;
        }
    }

}
