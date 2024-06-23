namespace BehaviourTree.Scripts.Nodes.Composite
{
    public class BTSelectorComposite : BTNode
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
                    
                    case NodeState.Success:
                        nodeState = NodeState.Success;
                        return nodeState;
                    
                    case NodeState.Failure:
                    default:
                        continue;
                }
            }

            nodeState = NodeState.Failure;
            return nodeState;
        }
    }
}