﻿using Xunit;
using PipServices3.Commons.Validate;

namespace PipServices3.Commons.Test.Validate
{
    //[TestClass]
    public class OnlyOneExistRuleTest
    {
        [Fact]
        public void TestOnlyOneExistRule()
        {
            var obj = new TestObject();
            var schema = new Schema().WithRule(new OnlyOneExistsRule("MissingProperty", "StringProperty", "NullProperty"));
            var results = schema.Validate(obj);
            Assert.Empty(results);

            schema = new Schema().WithRule(new OnlyOneExistsRule("StringProperty", "NullProperty", "intField"));
            results = schema.Validate(obj);
            Assert.Single(results);
        }
    }
}
