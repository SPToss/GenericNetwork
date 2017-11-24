using GenericNetwork.Domain.Neuron.ActivactionFunctions;

namespace GenericNetwork.Domain.Neuron
{
    public class Neurons<TNeuron> : NeuronsBase<TNeuron> where TNeuron : NeuronBase, new()
    {
    }
}