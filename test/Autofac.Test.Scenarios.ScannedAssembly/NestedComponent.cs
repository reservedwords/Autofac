namespace Autofac.Test.Scenarios.ScannedAssembly
{
    internal class NestedComponent    
    {
        public class PublicNestedComponent : IImplementedByPublicNestedComponent
        {

        }

        protected class ProtectedNestedComponent : IImplementedByProtectedNestedComponent
        {

        }

        private class PrivateNestedComponent : IImplementedByPrivateNestedComponent
        {

        }
    }
}
