using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agente : MonoBehaviour
{

    public Transform[] objetivo;
    NavMeshAgent nma;
    int indiceObjetivos=0;

    void Awake()
    {
        nma=GetComponent<NavMeshAgent>();
    }
    // Start is called before the first frame update
    void Start()
    {
        nma.SetDestination(objetivo[indiceObjetivos].position);
    }

    // Update is called once per frame
    void Update()
    {
        if (nma.hasPath)
        {
            if (nma.remainingDistance < 1)
            {
              indiceObjetivos++;
              indiceObjetivos = indiceObjetivos == objetivo.Length ? 0 : indiceObjetivos;
              nma.SetDestination(objetivo[indiceObjetivos].position);
            }
        }
    }
}
