using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    [SerializeField] GameObject particleprefab;

    private shake shake;
    Level level;

    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("screenShake").GetComponent<shake>();

        level = FindObjectOfType<Level>();
        level.countBreakables();
    }

    private void OnCollisionEnter(Collision other)
    {
        switch (other.collider.gameObject.tag)
        {
            case "Ball":
                level.reduceBreakableNumber();
                shake.shaking();
                var prefab = Instantiate(particleprefab, transform.position, Quaternion.identity);
                Destroy(prefab, 1f);

                Destroy(this.gameObject);
                break;
        }
    }

}
