using UnityEngine;
using DG.Tweening;

public class TransformDOTween : MonoBehaviour
{
    public Transform cube;
    public Transform sphere;
    public Transform capsule;
    public Transform quad;
    public Transform cylinder;

    

    public void TweenCapsule()
    {
        // Move the capsule to the position (0, 0, 0) in 1 second
        capsule.DOMove(Vector3.zero, 1f);
    }

    public void TweenSphere()
    {
        // Move the sphere only in the x-axis to the position 5 in 1 second
        sphere.DOMoveX(5, 1f);
    }

    public void TweenCube()
    {
        // Rotate the cube 45 degrees in the y-axis in 1 second
        cube.DORotate(new Vector3(0, 45, 0), 1f);
    }

    public void ContinuislyTweenQuad()
    {
        //Rotate per button click
        quad.DORotate(quad.localRotation.eulerAngles + new Vector3(0, 90, 0), 1f);
    }

    public void ChangeScale()
    {
        // Change the scale of the shape to 2 in 1 second
        cylinder.DOScale(2, 1f);
    }
}
