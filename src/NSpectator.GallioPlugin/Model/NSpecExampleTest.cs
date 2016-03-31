using Gallio.Model;
using Gallio.Model.Tree;
using NSpectator.Domain;
using Reflector = Gallio.Common.Reflection.Reflector;

namespace NSpectator.GallioPlugin.Model
{
    public class NSpecExampleTest : Test
    {
        readonly ExampleBase _example;
        public ExampleBase Example { get { return this._example; } }

        public NSpecExampleTest( ExampleBase example )
            : base( example.Spec, null )
        {
            this.Kind = TestKinds.Test;
            this.IsTestCase = true;
            this._example = example;
        }
    }
}