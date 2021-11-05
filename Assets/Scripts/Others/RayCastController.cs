using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class RayCastController : MonoBehaviour {
    public LayerMask collisionMask;
    public const float skinWidth = .015f;
    public int horizontalRayCount = 4, verticalRayCount = 4;
    public CollisionInfo collisions;

    [HideInInspector]
    public float hRaySpacing, vRaySpacing;

    [HideInInspector]
    public BoxCollider2D collider;
    public RaycastOrigins raycastOrigins;

    public void Start() {
        collider = GetComponent<BoxCollider2D>();
        CalculateRaySpacing();
    }

    //public virtual void: when making a method virtual, it'll not override this method, and it'll still be called.
    public void UpdateRaycastOrigins() {
        Bounds bounds = collider.bounds;
        bounds.Expand(skinWidth * -2);

        raycastOrigins.bottomLeft = new Vector2(bounds.min.x, bounds.min.y);
        raycastOrigins.bottomRight = new Vector2(bounds.max.x, bounds.max.y);
        raycastOrigins.topLeft = new Vector2(bounds.min.x, bounds.min.y);
        raycastOrigins.topRight = new Vector2(bounds.max.x, bounds.max.y);
    }

    public void CalculateRaySpacing() {
        Bounds bounds = collider.bounds;
        bounds.Expand(skinWidth * -2);

        horizontalRayCount = Mathf.Clamp(horizontalRayCount, 2, int.MaxValue);
        verticalRayCount = Mathf.Clamp(verticalRayCount, 2, int.MaxValue);
    }

    //Corners of collider
    public struct RaycastOrigins {
        public Vector2 topLeft, topRight;
        public Vector2 bottomLeft, bottomRight;
    }

    //Bunch of public bools
    public struct CollisionInfo {
        public bool above, below;
        public bool left, right;
        public bool climbingSlope, decsendingSlope;
        public float slopeAngle, slopeAngleOld;
        public Vector3 velocityOld; //where else do you put this lol

        public void Reset() {
            above = below = false;
            left = right = false;
            climbingSlope = false;
            decsendingSlope = false;
            slopeAngleOld = slopeAngle;
            slopeAngle = 0;
        }
    }
}
