using System;
using System.Collections.Generic;
using GenericNetwork.Domain.Neuron;
using GenericNetwork.Domain.Neuron.ActivactionFunctions;

namespace GenericNetwork.Domain.Network
{
    public class Network<TNetworkData, TActivation, TNeurons> : NetworkDataBase<TNetworkData, TActivation, TNeurons> where TNetworkData : ICollection<Tuple<NetworkInputBase, NetworkOutputBase>> where TActivation : ActivactionFunctionBase, new() where TNeurons : NeuronBase<TActivation>, new()
    {
        public Network(TNetworkData t) : base(t)
        {
        }
    }
}
