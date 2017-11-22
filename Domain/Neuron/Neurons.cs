using GenericNetwork.Domain.Neuron.ActivactionFunctions;

namespace GenericNetwork.Domain.Neuron
{
    public class Neurons<TActivation,TNeurons> : NeuronsBase<TActivation,TNeurons> where TActivation : ActivactionFunctionBase, new() where TNeurons : NeuronBase<TActivation>, new()
    {
    }
}