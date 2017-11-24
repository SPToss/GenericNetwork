using System;
using System.Collections.Generic;
using GenericNetwork.Domain.Neuron;

namespace GenericNetwork.Domain.Network
{
    public sealed class Network<TNeuron> : NetworkDataBase<TNeuron> where TNeuron : NeuronBase, new()
    {
        public Network(ICollection<Tuple<NetworkInputBase, NetworkOutputBase>> t) : base(t)
        {
        }
    }
}