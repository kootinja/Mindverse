using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickTransform : MonoBehaviour
{
    public Vector2 newPos = new Vector2();
    public Vector2 origPos = new Vector2();
    private float animSpeed = .04f;
    public void TransformMenuItem()
    {
        transform.LeanMoveLocal(newPos, animSpeed).setOnComplete(OnComplete);
    }

    public void OnComplete()
    {
        transform.LeanMoveLocal(origPos, animSpeed);
    }
}
