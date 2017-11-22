using GenericNetwork.Domain.Neuron.ActivactionFunctions;

namespace GenericNetwork.Domain.Neuron
{
    public abstract class NeuronBase<TActivation> where TActivation : ActivactionFunctionBase, new()
    {
        protected int Value;
        protected double Vage;
        private readonly TActivation _activation;

        protected NeuronBase()
        {
            _activation = new TActivation();
        }

        public double Activate(double value)
        {
            return _activation.Run(value);
        }

        public void SetVage(double vage)
        {
            Vage = vage;
        }
    }
}