using System;
using System.Collections.Generic;
using System.Linq;
using GenericNetwork.Domain.Neuron;
using GenericNetwork.Domain.Neuron.ActivactionFunctions;

namespace GenericNetwork.Domain.Network
{
    public abstract class NetworkDataBase<TNetworkData,TActivation, TNeurons> where TNetworkData : ICollection<Tuple<NetworkInputBase,NetworkOutputBase>> where TActivation : ActivactionFunctionBase, new() where TNeurons : NeuronBase<TActivation>, new()
    {
        private readonly TNetworkData _t;
        private Random _random;

        protected Neurons<TActivation,TNeurons> InputNeurons;
        protected Neurons<TActivation, TNeurons> HiddenNeurons;
        protected Neurons<TActivation, TNeurons> OutputNeurons;

        protected NetworkDataBase(TNetworkData t)
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
