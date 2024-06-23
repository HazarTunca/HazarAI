namespace BehaviourTree.Scripts.Nodes.Composite
{
    public class BTSequenceComposite : BTNode
    {
        public BTNode[] nodes;
        
        public override NodeState Execute()
        {
            foreach (var node in nodes)
            {
                switch (node.Execute())
                {
                    case NodeState.Running:
                        nodeState = NodeState.Running;
                        return nodeState;
                    
                    case NodeState.Failure:
                        nodeState = NodeState.Failure;
                        return nodeState;
                    
                    case NodeState.Success:
                    default:
                        continue;
                }
            }

            nodeState = NodeState.Success;
            return nodeState;
        }
    }
}