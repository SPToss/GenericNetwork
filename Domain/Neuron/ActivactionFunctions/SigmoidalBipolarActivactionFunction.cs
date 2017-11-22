using System;

namespace GenericNetwork.Domain.Neuron.ActivactionFunctions
{
    public class SigmoidalBipolarActivactionFunction : ActivactionFunctionBase
    {
        public override double Run(double value)
        {
            return 1 / (1 + Math.Pow(Math.E, -value));
        }
    }
}