using UnityEngine;

namespace BehaviourTree.Scripts.Nodes.Composite
{
    public class BTRandomSelectorComposite : BTNode
    {
        public BTNode[] nodes;
        NodeState currentState;
        
        public override NodeState Execute()
        {
            if (nodes == null || nodes.Length == 0)
            {
                return NodeState.Failure;
            }

            if(currentState == NodeState.Running)
            {
                return NodeState.Running;
            }
            
            int randomIndex = Random.Range(0, nodes.Length);
            currentState = nodes[randomIndex].Execute();
            return currentState;
        }
    }
}