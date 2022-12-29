using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPatrol : MonoBehaviour
{
    [SerializeField]
    private LayerMask _nonInteractableLayerMask;
    [SerializeField]
    private float _speed = 10f;
    [SerializeField]
    private float _lineOfSight = 10;
    [SerializeField]
    private List<Transform> _points = new List<Transform>();
    [SerializeField]
    private bool _iSeePlayer;
    [SerializeField]
    private Vector2 dir;
    private int _pointIndex;

    // Start is called before the first frame update
    void Start()
    {

        //_points.Add((new GameObject()).transform);
    }

    // Update is called once per frame
    void Update()
    {
        WaitPlayer();

        if (_iSeePlayer)
        {

        }
        else
        {
            Walk();
        }
    }

    private void WaitPlayer()
    {
        //dir = new Vector2(transform.position.x - player.Instance.PlayerTransform.position.x, transform.position.y - player.Instance.PlayerTransform.position.y);
        dir = player.Instance.PlayerTransform.position - transform.position;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, dir, _lineOfSight, _nonInteractableLayerMask);

        //Debug.Log($"{hit.collider.name}");

        Debug.DrawLine(transform.position, hit.point, Color.red);
    }

    private void Walk()
    {
        //int i = 0;
        transform.position = Vector3.MoveTowards(transform.position, _points[_pointIndex].position, _speed * Time.deltaTime);

        /*Quaternion rotation = Quaternion.LookRotation(_points[_pointIndex].position, look);
        transform.rotation = rotation;

        Debug.Log($"{Vector3.Distance(transform.position, _points[_pointIndex].position)}");
        Debug.Log($"{Vector3.Distance(transform.position, _points[_pointIndex].position) < 0.1f}");*/

        if (Vector3.Distance(transform.position, _points[_pointIndex].position) < 0.1f)
        {
            _pointIndex++;
            
            if(_pointIndex > _points.Count - 1)
            {
                _pointIndex = 0;
            }
        }

    }
}
