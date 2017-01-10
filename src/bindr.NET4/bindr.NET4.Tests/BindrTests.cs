using System.Collections;
using System.Collections.Specialized;
using Shouldly;

namespace bindr.NET4.Tests
{
    public class BindrTests
    {
        private const string Id = "1";
        private const string Value = "Howdy";
        private readonly TestObject _result;

        public BindrTests()
        {
            var bindr = new Bindr();
            var @object = new NameValueCollection();
            @object.Add("Id", Id);
            @object.Add("Value", Value);
            var testObject = new TestObject();
            _result = bindr.Bind(@object, testObject);
        }


        public void VerbatimPropertyBindingInt()
        {
            _result.Id.ShouldBe(Id);
        }

        public void VerbatimPropertyBindingString()
        {
            _result.Value.ShouldBe(Value);
        }

        public class TestObject
        {
            public string Id { get; set; }
            public string Value { get; set; }
        }
    }
}
