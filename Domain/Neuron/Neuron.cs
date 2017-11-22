using GenericNetwork.Domain.Neuron.ActivactionFunctions;

namespace GenericNetwork.Domain.Neuron
{
    public class Neuron<TActivation> : NeuronBase<TActivation> where TActivation : ActivactionFunctionBase, new()
    {
    }
}
