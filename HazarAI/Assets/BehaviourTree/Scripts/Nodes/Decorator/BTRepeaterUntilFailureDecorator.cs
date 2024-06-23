namespace BehaviourTree.Scripts.Nodes.Decorator
{
    public class BTRepeaterUntilFailureDecorator : BTNode
    {
        public BTNode node;

        public override NodeState Execute()
        {
            switch (node.Execute())
            {
                case NodeState.Running:
                    nodeState = NodeState.Running;
                    return nodeState;
                
                case NodeState.Success:
                    nodeState = NodeState.Running;
                    return nodeState;
                
                case NodeState.Failure:
                default:
                    nodeState = NodeState.Failure;
                    return nodeState;
            }
        }
    }
}