using DummyWPF;

namespace DummyWPFTests;

public class MathHelperTests {
    [Fact]
    public void AddWillReturnTrueValue() {
        var mh = new MathHelper();
        Assert.Equal( 5, mh.Add( 2, 3 ) );
    }

    [Fact]
    public void SubWillReturnTrueValue() {
        var mh = new MathHelper();
        Assert.Equal( 1, mh.Sub( 3, 2 ) );
    }
}