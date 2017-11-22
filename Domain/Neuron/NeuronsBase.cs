using System.Collections.Generic;
using GenericNetwork.Domain.Neuron.ActivactionFunctions;

namespace GenericNetwork.Domain.Neuron
{
    public abstract class NeuronsBase<TActivation,TNeurons> :List<TNeurons> where TActivation : ActivactionFunctionBase, new() where TNeurons : NeuronBase<TActivation>, new ()
    {
    }
}