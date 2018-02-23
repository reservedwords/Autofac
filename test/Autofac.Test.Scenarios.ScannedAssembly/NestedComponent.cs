namespace Autofac.Test.Scenarios.ScannedAssembly
{
    internal class NestedComponent    
    {
        public class PublicNestedComponent : IImplementedByPublicNestedComponent
        {

        }

        private class PrivateNestedComponent : IImplementedByPrivateNestedComponent
        {
            
        }
    }
}
