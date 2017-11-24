using System;
using System.Collections.Generic;
using System.Linq;
using GenericNetwork.Domain.Neuron;

namespace GenericNetwork.Domain.Network
{
    public abstract class NetworkDataBase<TNeuron> where TNeuron : NeuronBase, new()
    {
        private readonly ICollection<Tuple<NetworkInputBase, NetworkOutputBase>> _t;
        private Random _random;

        protected NeuronsBase<TNeuron> InputNeurons;
        protected NeuronsBase<TNeuron> HiddenNeurons;
        protected NeuronsBase<TNeuron> OutputNeurons;

        protected NetworkDataBase(ICollection<Tuple<NetworkInputBase, NetworkOutputBase>> t)
        {
            _t = t;
        }

        public NetworkInputBase GetInputValue(int iterator)
        {
            if (_t.Count >= iterator)
            {
                return _t.ToList()[iterator].Item1;
            }
            throw new Exception($"{iterator} is not find in list of input elements");
        }

        public NetworkOutputBase GetOutputValue(int iterator)
        {
            if (_t.Count >= iterator)
            {
                return _t.ToList()[iterator].Item2;
            }
            throw new Exception($"{iterator} is not find in list of output elements");
        }

        public Tuple<NetworkInputBase, NetworkOutputBase> GetRandomData()
        {
            if (_random == null)
            {
                _random = new Random(DateTime.Now.Millisecond);
            }
            var iterator = _random.Next(0, _t.Count);
            return _t.ToList()[iterator];
        }
    }
}
