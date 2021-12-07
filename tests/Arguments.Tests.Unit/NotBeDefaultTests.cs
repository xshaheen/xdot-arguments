using X.Arguments;

namespace Arguments.Tests.Unit;

public class NotBeDefaultTests {
    [Fact]
    public void should_throw_argument_exception_when_pass_default_value() {
        var zero = 0;
        Assert.Throws<ArgumentException>(nameof(zero), () => It.Should.NotBeDefault(zero));
        int? nullableZero = 0;
        Assert.Throws<ArgumentException>(nameof(nullableZero), () => It.Should.NotBeDefault(nullableZero));
        var emptyGuid = Guid.Empty;
        Assert.Throws<ArgumentException>(nameof(emptyGuid), () => It.Should.NotBeDefault(emptyGuid));
        var defaultDateTime = default(DateTime);
        Assert.Throws<ArgumentException>(nameof(defaultDateTime), () => It.Should.NotBeDefault(defaultDateTime));
    }

    [Fact]
    public void should_do_nothing_given_non_default_value_and_return_expected_value() {
        It.Should.NotBeDefault(1).Should().Be(1);
        It.Should.NotBeDefault((int?) -1).Should().Be((int?) -1);
        It.Should.NotBeDefault((int?) 1).Should().Be((int?) 1);
        It.Should.NotBeDefault((int?) null).Should().Be(null);
        It.Should.NotBeDefault(new DateTime(2000, 1, 1)).Should().Be(new DateTime(2000, 1, 1));
        var guid = Guid.NewGuid();
        It.Should.NotBeDefault(guid).Should().Be(guid);
    }
}
