using System.Collections.Generic;
using GenericNetwork.Domain.Neuron.ActivactionFunctions;

namespace GenericNetwork.Domain.Neuron
{
    public abstract class NeuronsBase<TNeurons, TActivation> :List<TNeurons>  where TNeurons : NeuronBase<TActivation>, new () where TActivation : ActivactionFunctionBase , new()
    {
    }
}