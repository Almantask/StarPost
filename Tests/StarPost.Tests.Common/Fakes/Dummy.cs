using AutoFixture;

namespace StarPost.Tests.Common.Fakes
{
    public static class Dummy
    {
        private static Fixture _fixture = new Fixture();

        public static T Any<T>() => _fixture.Create<T>();

        public static IEnumerable<T> AnyMany<T>() => _fixture.CreateMany<T>();
    }
}