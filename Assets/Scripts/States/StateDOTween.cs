using UnityEngine;
using DG.Tweening;

public class StateDOTween : MonoBehaviour
{
    public Transform cube, sphere, capsule;
    Tween signTween;



    public void MoveCube()
    {   
        // Moves the cube to the position (0, 0, 0) over 1 second. Once the movement is complete,
        // scales the sphere to (2, 2, 2) over 1 second.
        cube.DOMove(Vector3.zero, 1f).OnComplete (() => {sphere.DOScale(new Vector3(2f, 2f, 2f), 1f); });
    }

    public void CapsuleTween()
    {
        signTween = capsule.DORotate(new Vector3(0, 0, -180), 1f).SetLoops(-1, LoopType.Incremental).OnKill(() =>
        {
            sphere.DOScale(new Vector3(2f, 2f, 2f), 1f);
        });
    }

    public void KillTween()
    {
        signTween.Kill();
    }
}
