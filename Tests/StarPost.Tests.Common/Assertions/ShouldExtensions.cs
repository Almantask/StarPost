using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace StarPost.Tests.Common.Assertions
{
    public static class ObjectAssertionsExtensions
    {
        public static ObjectAssertions Should(this object instance)
        {
            return new ObjectAssertions(instance);
        }
    }

    public class ObjectAssertions :
        ReferenceTypeAssertions<object, ObjectAssertions>
    {
        public ObjectAssertions(object instance) : base(instance)
        {
        }

        protected override string Identifier => "objectc";

        public AndConstraint<ObjectAssertions> MatchProvidedPropertiesOf(object expectedInstance, string because = "", params object[] becauseArgs)
        {
            Subject
                .Should()
                .BeEquivalentTo(expectedInstance, options => options.ExcludingMissingMembers());
            return new AndConstraint<ObjectAssertions>(this);
        }
    }

}
